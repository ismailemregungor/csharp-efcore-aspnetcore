using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAdoNetBaglantiliYontem.HR2
{
    public interface ISet<T> where T : class
    {
        List<T> GetAll();
        T Find (int id);
    }
}
