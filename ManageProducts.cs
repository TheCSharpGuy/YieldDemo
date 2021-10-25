using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace YieldDemo
{
    [MemoryDiagnoser]
    public class ManageProducts
    {
        [Benchmark]
        public void ListProducts()
        {
            var catalogue = GetProducts(1000);
            foreach (var product in catalogue)
            {
                if (product.ID > 1000)
                    break;
                //if (product.ID < 500)
                //    Console.WriteLine($"SKU: {product.SKU},\n Name: {product.Name}");
                //else
                //    break;
            }
        }

        static IEnumerable<Product> GetProducts(int count)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < count; i++)
            {
                products.Add(new Product() { 
                    ID = i,
                    SKU = $"SKU_{i}", 
                    Name = $"Name {i}", 
                    MfgName = $"Mfg by {i}", 
                    Cost  = i * 23.00, 
                    IsPerishable = i%2!=0 
                });
            }
            return products;
        }

        [Benchmark]
        public void ListProductsYield()
        {
            var catalogue = GetProductsYield(1000);
            foreach (var product in catalogue)
            {
                if (product.ID > 1000)
                    break;
                //if (product.ID < 500)
                //    Console.WriteLine($"SKU: {product.SKU},\n Name: {product.Name}");
                //else
                //    break;
            }
        }
        static IEnumerable<Product> GetProductsYield(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return new Product()
                {
                    ID = i,
                    SKU = $"SKU_{i}",
                    Name = $"Name {i}",
                    MfgName = $"Mfg by {i}",
                    Cost = i * 23.00,
                    IsPerishable = i%2!=0
                };
            }
        }
    }
}
