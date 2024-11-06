using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProductApp
{
    public static class ProductDataLoader
    {
        public static List<Product> LoadProducts(string filePath)
        {
            List<Product> products = new List<Product>();

            // Read all lines from the CSV file
            var lines = File.ReadAllLines(filePath).Skip(1); // Skip header line

            // Parse each line into a Product object
            foreach (var line in lines)
            {
                var columns = line.Split(',');

                // Assuming the columns are in the correct order and can be parsed
                products.Add(new Product
                {
                    ProductId = int.Parse(columns[0]),
                    ProductName = columns[1],
                    ProductPrice = decimal.Parse(columns[2]),
                    ProductCalcCode = columns[3]
                });
            }

            return products;
        }
    }
}
