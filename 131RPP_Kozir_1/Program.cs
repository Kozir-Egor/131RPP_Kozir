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
            //1 пункт//////////////////////////////
            int x, y; //объявление переменных
            //2 пункт//////////////////////////////
            Console.WriteLine("Введите x");
            x = Convert.ToInt32(Console.ReadLine()); //ввод с консоли
            Console.WriteLine("Введите y");
            y = Convert.ToInt32(Console.ReadLine());
            //3 пункт////////////////////////////////////
            int z; //объявление z
            z = x + y; //сумма z
            //4 пункт/////////////////////////////////
            Console.WriteLine("{1}+{2}={0}", z, x, y); //вывод z
            //5 пункт/////////////////////////////////////
            if (z > 0)
            {
                Console.WriteLine("z-положительное");    ///
            }
            else                                        ///положительное или отрицательнлое
            {
                Console.WriteLine("z-отрицательнлое");  ///
            }

            if (z % 2 == 0)
            {
                Console.WriteLine("z-четное");      ///
            }
            else                                   //четное или нечетное
            {
                Console.WriteLine("z-не четное");  //
            }
            if (z % 5 == 0)
            {
                Console.WriteLine("Кратно 5");       ///
            }
            else                                    //делиться ли оно на 5, 10, 20 без остатка
            {
                Console.WriteLine("Не кратно 5");   ///

            }
           //6-7 пункты////////////////////////////////////
            start:
              if (z > 0)
              {
                z--;
                Console.WriteLine(z);          ////оператор goto 
                   goto start;
               }
            //8-9 пункты///////////////////////////////////
            while (z > 0)
            {
                z--;                           //инструкция while
               Console.WriteLine(z);
            }
            //10 пункт/////////////////////////////////////
            for (i = z; z > 0; z--)
            {
                Console.WriteLine(z);            //инструкцию for
            }

            Console.ReadKey();
        }
    }
}
