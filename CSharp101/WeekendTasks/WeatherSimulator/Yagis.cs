using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendTasks.WeatherSimulator
{
    internal class Yagis
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public string Sembol { get; protected set; }
        public DateTime OlusturmaZamani { get; }

        public Yagis(int x, int y)
        {
            X = x;
            Y = y;
            OlusturmaZamani = DateTime.Now;
        }

        public void Goster()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sembol);
        }
    }
}
