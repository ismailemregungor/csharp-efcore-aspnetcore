using OOP_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTasks.StockManagement.Managers
{
    internal class MarketManager
    {
        public StokManager StokManager { get; set; }

        public PersonelManager PersonelManager { get; set; }

        public MarketManager()
        {
            StokManager = new StokManager();
            PersonelManager = new PersonelManager();
        }
    }
}
