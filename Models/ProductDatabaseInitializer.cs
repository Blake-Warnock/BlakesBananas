using BlakesBananas.Controllers;
using System.Collections.Generic;
using System.Data.Entity;

namespace BlakesBananas.Models

{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Bananas"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Merch"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Other Food"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Gift Cards/Tours"
                },

            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                //Plan Bananas
                new Product
                {
                    ProductID = 1,
                    ProductName = "Banana Bundle Size(5lbs)",
                    Description = "Filler Text",
                    ImagePath="bananaBox1.png",
                    UnitPrice = 97.00,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Banana Bundle Size(10lbs)",
                    Description = "Filler Text",
                    ImagePath="bananaBox2.png",
                    UnitPrice = 147.00,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Banana Bundle Size(20lbs)",
                    Description = "Filler Text",
                    ImagePath="bananaBox3.png",
                    UnitPrice = 197.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Banana Bundle Size(40lbs)",
                    Description = "Filler Text",
                    ImagePath="bananaBox3.png",
                    UnitPrice = 297,
                    CategoryID = 1
                },
                //Organic Bananas
                new Product
                {
                    ProductID = 5,
                    ProductName = "Organic Banana Bundle Size(5lbs)",
                    Description = "Filler Text",
                    ImagePath="oBananaBox1.png",
                    UnitPrice = 117.00,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Organic Banana Bundle Size(10lbs)",
                    Description = "Filler Text",
                    ImagePath="oBananaBox2.png",
                    UnitPrice = 167.00,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Organic Banana Bundle Size(20lbs)",
                    Description = "Filler Text",
                    ImagePath="oBananaBox3.png",
                    UnitPrice = 217.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Organic Banana Bundle Size(40lbs)",
                    Description = "Filler Text",
                    ImagePath="oBananaBox3.png",
                    UnitPrice = 317,
                    CategoryID = 1
                },
                 //Other Banana's
                new Product
                {
                    ProductID = 9,
                    ProductName = "Patent Pending Banana Bundle Size(5lbs)",
                    Description = "Filler Text",
                    ImagePath="pBananaBox1.png",
                    UnitPrice = 107.00,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Patent Pending Banana Bundle Size(10lbs)",
                    Description = "Filler Text",
                    ImagePath="pBananaBox2.png",
                    UnitPrice = 157.00,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Patent Pending Banana Bundle Size(20lbs)",
                    Description = "Filler Text",
                    ImagePath="oBananaBox3.png",
                    UnitPrice = 207.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Patent Pending Banana Bundle Size(40lbs)",
                    Description = "Filler Text",
                    ImagePath="pBananaBox3.png",
                    UnitPrice = 307,
                    CategoryID = 1
                },

            };

            return products;
        }
    }
}
