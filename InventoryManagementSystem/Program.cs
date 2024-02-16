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

            AddProduct(inventoryManager);
            Console.WriteLine("");
            DeleteProduct(inventoryManager);
            Console.WriteLine("product was deleted successfully");

            int ProductItToRetrieve = 2;

            Product ProductToSell = inventoryManager.GetProduct(ProductItToRetrieve);


            if(ProductToSell != null)
            {
                Console.WriteLine($"Initial stock of {ProductToSell.Name}: {ProductToSell.Stock}");
                int quantitySold = 34;
                inventoryManager.RecordSale(ProductToSell, quantitySold);
                Console.WriteLine($"Uptadet stock of {ProductToSell.Name}: {ProductToSell.Stock}");

            }
            else
            {
                Console.WriteLine($"Product with id: {ProductItToRetrieve} not found.");
            }

            var allProducts = inventoryManager.GetAllProducts();

            foreach (var product in allProducts)
            {
                Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
            }

            return Task.CompletedTask;
        }

        static void AddProduct(InventoryManager inventoryManager)
        {

            Console.WriteLine("Please enter product name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter price: ");
            var priceDecimal = decimal.TryParse(Console.ReadLine(), out var price);
            Console.WriteLine("please enter amount of stock: ");
            var stockInt = int.TryParse(Console.ReadLine(), out var stock);


            Product newProduct = new Product
            {
                Name = name,
                Price = price,
                Stock = stock
            };

            inventoryManager.AddProduct(newProduct);
            Console.WriteLine("Product was added successfully.");
        }
        static void DeleteProduct(InventoryManager inventoryManager)
        {
            inventoryManager.DeleteProduct(6);
        }
    }
}