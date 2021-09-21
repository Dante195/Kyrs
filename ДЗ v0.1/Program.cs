using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_v0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввелите первое значение b^2");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("Ввелите Второе значение a");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Ввелите Третье значение c");
            double C = double.Parse(Console.ReadLine());
            double D = (B * B) - (4 * (A * C));
            Console.WriteLine("Дискреминант равен" + D);
            Console.WriteLine("Найдем х-сы");
            //спросил брата по  Math.Sqrt(D)
            double x1 = (-B + Math.Sqrt(D))/(2 * A);
            Console.WriteLine("Х1=" + x1);
            double x2 = (-B - Math.Sqrt(D)) / (2 * A);
            Console.WriteLine("Х2=" + x2);
            // воспользовался метанитом но чисто взглянул

            if(x1>0)
            {
                Console.WriteLine("1 корень");
            }
            else
            {
                Console.WriteLine("нет корней");
                    }
            if (x2 > 0)
            {
                Console.WriteLine("1 корень");
            }
            else
            {
                Console.WriteLine("нет корней");
            }
            Console.ReadKey();
            

        }
            
    }

}
