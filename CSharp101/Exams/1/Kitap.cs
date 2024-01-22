using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTasks._1
{
    internal class Kitap
    {
        public int Id { get; set; }

        // private sadece bu class içerisinde set edilebilir.
        private string ISBN { get; set; }

        public Kitap(int Id, string iSBN)
        {
            // Bu problemi çöz: this kullanılabilir, parametre adı farklı olabilir vs.
            Id = Id;
            ISBN = iSBN;
        }
    }
}
