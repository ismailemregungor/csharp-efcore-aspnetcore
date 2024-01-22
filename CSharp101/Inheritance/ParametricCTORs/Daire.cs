using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.ParametricCTORs
{
    internal class Daire
    {

    //Silindir sınıfı oluşturulurken mutlaka Daire sınıfının ctor'una 
    //parametre aktarılmadılır.
    //Bunun için base keyword'u ile veri aktarımı yaparız.
        public Daire(double r)
        {

        }
    }
}
