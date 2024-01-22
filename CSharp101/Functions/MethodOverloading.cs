using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class MethodOverloading
    {

        // iki sayıyı toplayan 5 tane aşırı yüklenmiş metod yaz.

        /// <summary>
        /// 2 int tipinde sayıyı toplar
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        int Topla(int s1, int s2)
        {
            return s1 + s2;
        }

        /// <summary>
        /// 3 int tipinde sayıyı toplar
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        int Topla(int s1, int s2, int s3)
        {
            return s1 + s2 + s3;
        }

        /// <summary>
        /// 2 double tipinde sayıyı toplar
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        double Topla(double s1, double s2)
        {
            return s1 + s2;
        }

        /// <summary>
        /// 3 double tipinde sayıyı toplar
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        double Topla(double s1, double s2, double s3)
        {
            return s1 + s2 + s3;
        }

        /// <summary>
        /// 4 int tipinde sayıyı toplar
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <param name="s4"></param>
        /// <returns></returns>
        static int Topla(int s1, int s2, int s3, int s4)
        {
            return s1 + s2 + s3 + s4;
        }
        //static void Main(string[] args)
        //{
        //    MethodOverloading methodOverloading = new MethodOverloading();
        //    Console.WriteLine(methodOverloading.Topla(5, 2));
        //    Console.WriteLine(methodOverloading.Topla(5, 2, 3));
        //    Console.WriteLine(methodOverloading.Topla(5.5, 2.3));
        //    Console.WriteLine(methodOverloading.Topla(5.5, 2.3, 1.7));
        //    //Console.WriteLine(methodOverloading.Topla(5, 2, 7, 6));
        //    Console.WriteLine(Topla(5, 2, 7, 6));

        //}
    }
}
