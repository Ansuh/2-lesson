using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__6_Inheritance
{
    class Jewelry
    {
        

        public Jewelry()
        {
            Console.WriteLine("Jewelry Ctor");
        }
        public Jewelry(Material material, decimal price, float weight, string brand)
        {
            BaseMaterial = material;
            Price = price;
            Weight = weight;
            Brand = brand;
        }

        public Material BaseMaterial { get; set; }

        public decimal Price { get; set; }
        public float Weight { get; set; }
        public string Brand { get; set; }

        public enum Material
        {
            Silver,
            Gold,
            Platinium,
            Other,

        }





    }
    
}
