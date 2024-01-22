using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Classes1
{
    internal class Personel
    {
        /*
         * Class Members
         */


        private int id;

        public int Get_Id()
        {
            return id;
        }

        public void Set_Id(int value)
        {
            id = value;
        }

        /*
         * C# 3.0 öncesi property'de property'nin kullanacağı değişken tanımlanmalıdır.
         */
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /*
         * Autoproperty
         */
        public string Surname { get; set; }

        public double Salary { get; set; }
    }
}
