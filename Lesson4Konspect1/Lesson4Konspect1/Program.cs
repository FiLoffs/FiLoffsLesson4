using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Konspect1
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Оператор goto
            //    // Обычный цикл for выводящий числа от 1 до 5
            //    Console.WriteLine("Обычный цикл for:");
            //    for (int i = 1; i <= 5; i++)
            //        Console.Write("\t{0}", i);
            //    // Реализуем то же самое с помощью оператора goto
            //    Console.WriteLine("\n\nА теперь используем goto:");
            //    int j = 1;
            //link1:
            //    Console.Write("\t{0}", j);
            //    j++;
            //    if (j <= 5) goto link1;
            //    Console.ReadLine();

            //===================================

            //// Оператор break
            //// В данном цикле выведутся числа от 1 до 5 вместо 100
            //for (int i = 1; i < 100; i++)
            //    if (i <= 5)
            //        Console.WriteLine(i);
            //    else break;
            //Console.ReadLine();

            //===================================

            //// Оператор continue
            //// Выводим числа кратные 5
            //for (byte i = 1; i <= 100; i++)
            //{
            //    if (i % 5 != 0) continue;
            //    Console.Write("\t{0}", i);
            //}
            //Console.ReadLine();

            //===================================

            //Оператор return
            //int result = Sum(230);
            Console.WriteLine("Введите число");
            int s = Convert.ToInt32(Console.ReadLine());
            int result = Sum(s);
            Console.WriteLine($"Сумма четных чисел от 1 до {s} равна: {result}");
            Console.WriteLine();
        }

        static int Sum(int s)
        {
            int mySum = 0;
            for (int i = 1; i <= s; i++)
                if (i % 2 == 0)
                    mySum += i;
            return mySum;
        }
    }
}
