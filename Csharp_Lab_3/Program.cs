using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Lab_3
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1----------------------
            string quest = "y";
            while (quest == "y")
            {
                Func<int, bool> isVisokosniy = year => year % 4 == 0 ? year % 100 == 0 ? year % 400 == 0 ? true : false : true : false;
                int years = Int32.Parse(Console.ReadLine());
                FunYear(years);
                bool xxx = isVisokosniy(years);
                Console.WriteLine(xxx);
                void FunYear(int year)
                {
                    if (year % 4 == 0 || year % 100 == 0 && year % 400 == 0)
                        Console.WriteLine("Год Високосный");
                    else
                        Console.WriteLine("Год Обычный");
                }
                quest = Console.ReadLine();
            }
            //-----------------------
            //============================================================================================
            //2----------------------
            double Fun(double num)
            {
                return Math.Sin(num);
            }
            double a = 0;
            double b = Math.PI / 2;
            double e = 0.001;
            double x;
            while (Math.Abs(a - b) >= e)
            {
                if (Fun(a) * Fun(b) > 0)
                {
                    return;
                }
                else
                {
                    x = (a + b) / 2;
                    if (Fun(a) * Fun(x) > 0)
                    {
                        a = x;
                    }
                    else
                        b = x;
                }
                Console.WriteLine(x);
            }
            //-----------------------
            //============================================================================================
            //3----------------------
            */
            
            Console.ReadLine();
        }
    }
}
