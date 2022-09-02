using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {

        static void PrintQuadro(int n, char s)
        {

            //задание1
            //Напишите метод, который отображает квадрат из
            //некоторого символа.Метод принимает в качестве параметра: длину стороны квадрата, символ.

            for (int i = 0; i< n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine();
            }

        }

        static bool Palindrom(int n)
        {

            //задание2
            //Напишите метод, который проверяет является ли
            //переданное число «палиндромом». Число передаётся в
            //качестве параметра.Если число палиндром нужно вернуть из метода true, иначе false.

            string s = n.ToString();
            char[] rev = s.ToCharArray();
            Array.Reverse(rev);
            string revers = new string(rev);
            if(s == revers)
            {
                return true;
            }
            
            return false;

        }

        static int[] ArrayFilter(int[] one, int[] two)
        {

            

        }

        static void Main(string[] args)
        {

            int[] one = new int[] { 5, 4, 7, 3, 8, 9, 2 };
            int[] two = new int[] { 4, 3, 2 };
            int[] arr = ArrayFilter(one, two);

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }

        }
    }
}
