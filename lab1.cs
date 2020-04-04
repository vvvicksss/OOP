using System;

namespace laba1
{
    class Program
    {
        static void main(string[] args)
        {
            Console.WriteLine("\nЛабораторна №1 ООП Павлик Вікторії ІС-93");
            int c1 = 31, c2 = 56, c3 = -25;//число для побітового збільшення
            int a1 = 44, a2 = 46;//числа для порівняння
            int b1 = 44, b2 = -7;//числа для порівняння
            int bit = 2;

            Console.WriteLine("\nВихідні числа: ",c1,c2,c3);
            increase(ref c1);
            increase(ref c2);
            increase(ref c3);
            Console.WriteLine("\nЗбільшені на 1 числа: ",c1,c2,c3);

            Console.WriteLine("\nЧисла для порівняння: ",a1,b1);
            Console.WriteLine("\nРезультат порівняння: ",compare(a1,b1, bit));

            Console.WriteLine("\nЧисла для порівняння: ",a2,b2);
            Console.WriteLine("\nРезультат порівняння: ",compare(a2,b2, bit));

            Console.ReadKey();
        }
        static int increase(ref int c)
        {
            int i;
            for (i = 1; (c & i) != 0; i <<= 1)
                c &= ~i;
 
            c |= i;
        }
        static bool compare(int a, int b, int bit)
        {
            bit = 1<<bit;       
            a &= bit;         
            b &= bit;       
            return !(a^b);
        }
    }
}