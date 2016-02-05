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
            int x, y; //объявление переменных
            Console.WriteLine("Введите x");
            x = Convert.ToInt32(Console.ReadLine()); //ввод с консоли
            Console.WriteLine("Введите y");
            y = Convert.ToInt32(Console.ReadLine());
            int z; //объявление z
            z = x + y; //сумма z
            Console.WriteLine("{1}+{2}={0}", z, x, y); //вывод z
           
            Console.ReadKey();
        }
    }
}
