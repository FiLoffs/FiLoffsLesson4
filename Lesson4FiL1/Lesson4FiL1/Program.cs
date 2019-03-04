using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4FiL1
{
    class Program
    {
        //упражнение на занятии
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)

            {

                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(Math.Pow(a,j)+"\t"); 

                }
                Console.WriteLine();
            }
        }
    }
}
