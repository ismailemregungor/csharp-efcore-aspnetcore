using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DependencyInversionPrinciple.Cozum
{
    internal class DatabaseManager2
    {
        // Dependency Injection --> Loosly Coupling - Gevşek Bağlı
        /*
         * Bağımlılık class'ın dışında geliyor yani bağımlığı tersine çevirdik.
         */
        private ICRUD _crud;
        // Constructor Injection
        public DatabaseManager2(ICRUD crud)
        {
            _crud = crud;
        }

        public string Oku()
        {
            return _crud.Read();
        }

        // Method Injection

        public void Inject(ICRUD crud)
        {
            _crud = crud;
        }

        // Property Injection


    }
}
