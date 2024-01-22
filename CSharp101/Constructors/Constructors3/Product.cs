using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors.Constructors3
{
    internal class Product
    {
        /*
         * Bir ürün sınıfı oluşturup, fiyat ile ilgili olarak negatif değer
         * girilmesini engelleyen yapıyı kurunuz.
         */

        public Product(int ProductId, string Name, int price) 
        {
            this.ProductId = ProductId;
            this.Name = Name;
            this.Price = price;
        }

        public int ProductId { get; set; }

        public string Name { get; set; }

        public int price;

        public int Price 
        { 
            get { return price; }

            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Negatif değer giremezsiniz!");
                    
                    price = 0;
                }
                else
                {
                    price = value;    
                }
            }
        }
    }
}
