using Buoi3.Models;

namespace Buoi3.Data
{
    public class DataSeeds
    {
        public static List<Category> categories = new List<Models.Category>()
        { 

            new Category(){CategoryId=1,CategoryName="Laptop",Description="Laptop description"},
            new Category(){CategoryId=2,CategoryName="Phone",Description="Phone description"},
            new Category(){CategoryId=3,CategoryName="Tablet",Description="Tablet description"}

        };
        public static List<Product> products = new List<Models.Product>()
        {



            new Product(){ProductId=1,ProductName="Iphone 18promax",Price=4,Description="Iphone 18 promax",CategoryId=2},
            new Product(){ProductId=2,ProductName="Dell 3410",Price=4,Description="Dell 3410",CategoryId=1},
            new Product(){ProductId=3,ProductName="Ipad gen4",Price=4,Description="Ipad gen4",CategoryId=3},

        };

    }
}
