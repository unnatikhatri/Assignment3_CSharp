using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_CSharp
{
    public class Product 
    {
        private string name;
        private float price;
        private int quantity;
        private string type;


        public Product()
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Type = type;

        }

        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }

    }
}
