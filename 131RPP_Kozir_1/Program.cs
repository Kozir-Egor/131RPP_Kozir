using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131RPP_Kozir_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Введите x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = Convert.ToInt32(Console.ReadLine());
            int z;
            z = x + y;
            Console.WriteLine("{1}+{2}={0}", z, x, y);
            Console.ReadKey();
        }
    }
}
