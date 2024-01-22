using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTasks.StockManagement.Interfaces
{
    internal interface IBozulabilir
    {
        public bool BozukMu { get; set; }

        public string BozulmaNedeni { get; set; }
    }
}
