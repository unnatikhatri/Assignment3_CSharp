using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Products = new List<Product>();

            //Adding Elements
            Products.Add(new Product()
            {
                Name = "Lettuce",
                Price = 10.5f,
                Quantity = 50,
                Type = "Leafy green"
            });
            Products.Add(new Product()
            {
                Name = "Cabbage",
                Price = 20,
                Quantity = 100,
                Type = "Cruciferous"
            });
            Products.Add(new Product()
            {
                Name = "Pumpkin",
                Price = 30,
                Quantity = 30,
                Type = "Marrow"
            });
            Products.Add(new Product()
            {
                Name = "Cauliflower",
                Price = 10,
                Quantity = 25,
                Type = "Cruciferous"
            });
            Products.Add(new Product()
            {
                Name = "Zucchini",
                Price = 20.5f,
                Quantity = 50,
                Type = "Marrow"
            });
            Products.Add(new Product()
            {
                Name = "Yam",
                Price = 30,
                Quantity = 50,
                Type = "Root"
            });
            Products.Add(new Product()
            {
                Name = "Spinach",
                Price = 10,
                Quantity = 100,
                Type = "Leafy Green"
            });
            Products.Add(new Product()
            {
                Name = "Broccoli",
                Price = 20.2f,
                Quantity = 75,
                Type = "Cruciferous"
            });
            Products.Add(new Product()
            {
                Name = "Garlic",
                Price = 30,
                Quantity = 20,
                Type = "Leafy Green"
            });
            Products.Add(new Product()
            {
                Name = "Silverbeet",
                Price = 10,
                Quantity = 50,
                Type = "Marrow"
            });

            //Printing total product numbers
            Console.WriteLine("Total number of products " + Products.Count());

            //Adding new element 
            Products.Add(new Product()
            {
                Name = "Potato",
                Price = 10,
                Quantity = 50,
                Type = "Root"
            });

            //Printing list elements
            Console.WriteLine("\n \n \n List of available products\n");
            foreach (var p in Products)
            {
                Console.WriteLine(p.Name + " : " + p.Price + " : " + p.Quantity + " : " + p.Type);
            }

            //Printing count after new insertion
            Console.WriteLine("\n \n Total number of Products now :"+ Products.Count());


            //Printing leafy products
            
            Console.WriteLine("\n \n \nLeafy Products are :");
            foreach (var p in Products)
            {
                if (p.Type == "Leafy green")
                    Console.WriteLine(p.Name + " : " + p.Price + " : " + p.Quantity + " : " + p.Type);
            }

            //Removing Garlic and Printing Total Number of Products Available
            Products.RemoveAt(9);

            Console.WriteLine("\n \n \nProducts after garlics were sold out :" + Products.Count());

            //User adding 50 cabbages so total no. of cabbages displayed
            foreach (var p in Products)
            {
                if (p.Name == "Cabbage")
                {
                    int temp = p.Quantity + 50;
                    Console.WriteLine("\n \n Number of cabbages :" + temp);
                }
            }

            //Calculating amount for 1kg lettuce, 2kg zucchini, 1kg broccoli
            double amount;
            amount = ((1 * 10.5) + (2 * 20.5) + (1 * 20.2));
            amount = Math.Round(amount);
            Console.WriteLine("\n \n \n Amount : Rs." + amount);
        }
    }
}
