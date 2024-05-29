using LearnApp.Collections.Enumerable;
using System;

namespace LearnApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new ProductCollection();
            products.Add(new Collections.Data.Product() { Id = 0, Description = "Desc0", Name = "name0", Price = 0, Stock = 0 }); 
            products.Add(new Collections.Data.Product() { Id = 1, Description = "Desc1", Name = "name1", Price = 1, Stock = 1 }); 
            products.Add(new Collections.Data.Product() { Id = 2, Description = "Desc2", Name = "name2", Price = 2, Stock = 2 });
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}");
            }

        }
    }
}
