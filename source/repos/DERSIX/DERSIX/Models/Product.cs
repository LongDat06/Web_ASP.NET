using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DERSIX.Models
{
    public class Product
    {
        private string id;
        private string name_products;
        private int price;
        private string img;
        public Product() { }

        public Product(string id, string name_products, int price, string img)
        {
            this.id = id;
            this.name_products = name_products;
            this.price = price;
            this.Img = img;
        }

        public string Id { get => id; set => id = value; }
        public string Name_products { get => name_products; set => name_products = value; }
        public int Price { get => price; set => price = value; }
        public string Img { get => img; set => img = value; }
    }
}
