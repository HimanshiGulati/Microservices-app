using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreConfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreConfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "Iphone X",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile = "ImageFile",
                    Price= 25,
                    Category ="Phone"

                },
                new Product()
                {
                    Name = "Samsung",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile = "ImageFile",
                    Price= 25,
                    Category ="Phone"
                }
            };
        }
    }
}
