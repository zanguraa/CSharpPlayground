using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class InventoryManager
    {
        private readonly string connectionString;

        public InventoryManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddProduct(Product product)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute("INSERT INTO Products (Name, Price, Stock) VALUES (@ProductName, @Price, @Stock)", product);
            }
        }

        public Product GetProduct(int productId)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                return connection.QueryFirstOrDefault<Product>("SELECT * FROM Products WHERE Id = @ProductId", new { ProductId = productId });
            }
        }

        public IEnumerable<Product> GetAllProducts ()
        {
            using (var connection = new SqlConnection (connectionString))
            {
                connection.Open();
                return connection.Query<Product>("SELECT * FROM Products");
            }
        }

        public void RecordSale(Product product, int quantitySold)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (product.Stock >= quantitySold)
                {
                    product.Stock -= quantitySold;
                    connection.Execute("UPDATE Products SET Stock = @Stock WHERE Id = @ProductId", new { Stock = product.Stock, ProductId = product.Id });

                    Sales sale = new Sales
                    {
                        ProductId = product.Id,
                        Quantity = quantitySold,
                        SaleDate = DateTime.Now,
                    };

                    connection.Execute("INSERT INTO Sales (ProductId, Quantity, SaleDate) VALUES (@ProductId, @Quantity, @SaleDate)", sale);
                } else
                {
                    Console.WriteLine("Not enought stock available for the sale");
                }
            }
        }

    }
}
