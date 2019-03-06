////Цикл for
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson4Konspect2
//{
//    class Program
//    {
//        // Данный метод выводит таблицу умножения
//        // размерностью b x b
//        static void tab(byte b)
//        {
//            Console.WriteLine("Таблица умножения {0} x {0}\n", b);
//            // Этот цикл проходит по строкам
//            for (int i = 1; i <= b; i++)
//            {
//                // Этот цикл проходит по столбцам
//                for (int j = 1; j <= b; j++)
//                    Console.Write("{0}\t", j * i);
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//        }

//        static void Main(string[] args)
//        {
//            tab(8);
//            // Давайте разберем нестандартные возможности цикла for
//            // ************************************************* //
//            // Применение нескольких переменных управления циклом
//            for (byte i = 0, j = 20; i <= j; i += 5, j -= 5)
//                //Console.WriteLine("i = {0}, j = {1}", i, j);
//                Console.WriteLine($"i = {j}, j = {j}");
//            Console.WriteLine();
//            // Использование условного выражения в цикле
//            bool b = false;
//            for (byte i = 1, j = 100; !b; i++, j--)
//                if (i < Math.Sqrt(j))
//                    Console.WriteLine("Число {0} меньше квадратного корня из {1} ", i, j);
//                else b = true;
//            // Отсутствие части цикла
//            int k = 0;
//            for (; k < 10;)
//            {
//                k++;
//                Console.Write(k);
//            }
//            Console.WriteLine("\n");
//            // Цикл без тела
//            int sum = 0;
//            for (int i = 1; i <= 10; sum += ++i) ;
//            Console.WriteLine("Значение суммы: {0}", sum);
//            Console.WriteLine();
//        }
//    }
//}

//Цикл while

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Пример возведения числа в несколько степеней
//            byte l = 2, i = 0;
//            int result = 1;
//            while (i < 10)
//            {
//                i++;
//                result *= l;
//                Console.WriteLine("{0} в степени {1} равно {2}",l,i,result);
//            }
//            Console.WriteLine();
//        }
//    }
//}

////Цикл do ... while
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                // Вычисляем факториал числа
//                int i, result = 1, num = 1;
//                Console.WriteLine("Введите число:");
//                i = int.Parse(Console.ReadLine());
//                Console.Write("\nФакториал {0} = ", i);
//                do
//                {
//                    result *= num;
//                    num++;
//                } while (num <= i);
//                Console.Write(result);
//            }
//            catch (FormatException ex)
//            {
//                Console.WriteLine("Вы ввели не число. {0}", ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine();
//            }
//        }
//    }
//}

//Цикл foreach
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявляем два массива
            int[] myArr = new int[5];
            int[,] myTwoArr = new int[5, 6];
            int sum = 0;
            Random ran = new Random();
            // Инициализируем массивы
            for (int i = 1; i <= 5; i++)
            {
                myArr[i - 1] = ran.Next(1, 20);
                for (int j = 1; j <= 6; j++)
                    myTwoArr[i - 1, j - 1] = ran.Next(1, 30);
            }
            // Вычисляем квадрат каждого элемента одномерного массива
            foreach (int fVar in myArr)
                Console.WriteLine("{0} в квадрате равно {1}", fVar, fVar * fVar);
        Console.WriteLine();
            // Вычислим сумму элементов многомерного массива
            foreach (int fTwoVar in myTwoArr)
            {
                sum += fTwoVar;
                Console.Write($"{fTwoVar}, ");
            }
            Console.WriteLine();
            Console.WriteLine("Сумма элементов многомерного массива: {0}",sum);
        Console.WriteLine();
        }
    }
}