using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using Dapper;

namespace InventoryManagementSystem
{
    internal class Program
    {
        static Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           InventoryManager inventoryManager = new InventoryManager("Data Source=DESKTOP-7OLVUTI;Initial Catalog=InventoryDB;Integrated Security=SSPI;TrustServerCertificate=True");
            
            Product newProduct = new Product
            {
                ProductName = "Xiaomi  13 Pro",
                Price = 637.35m,
                Stock = 45
            };
            
            inventoryManager.AddProduct(newProduct);
            Console.WriteLine("Product was added successfully.");

            int ProductItToRetrieve = 2;

            Product ProductToSell = inventoryManager.GetProduct(ProductItToRetrieve);


            if(ProductToSell != null)
            {
                Console.WriteLine($"Initial stock of {ProductToSell.ProductName}: {ProductToSell.Stock}");
                int quantitySold = 34;
                inventoryManager.RecordSale(ProductToSell, quantitySold);
                Console.WriteLine($"Uptadet stock of {ProductToSell.ProductName}: {ProductToSell.Stock}");

            }
            else
            {
                Console.WriteLine($"Product with id: {ProductItToRetrieve} not found.");
            }

            var allProducts = inventoryManager.GetAllProducts();

            foreach (var product in allProducts)
            {
                Console.WriteLine($"Product ID: {product.Id}, Name: {product.ProductName}, Price: {product.Price}, Stock: {product.Stock}");
            }

            return Task.CompletedTask;
        }
    }
}