using System;

namespace laba4
{
    class Vector
    {
        private int r;
        private int f;
        //конструктор, що ініціалізує координати нулями
        public Vector()
        {
            r = 0;
            f = 0;
        }    
        //конструктор з параметрами
        public Vector(int vr, int vf)
        {
             r = vr;
             f = vf;
        }
        //конструктор копіювання
        public Vector(Vector other)
        {
            r = other.r;
            f = other.f;
        }
        //метод повороту вектору на будь-який кут
        public int Rotate(int vf)
        {
               f += vf;
               return f;
        }
        //метод отримання даних вектору
        public void Print()
        {
             Console.WriteLine("\nВідстань від полюсу: {0}\nКут між полярною віссю: {1}",r,f);
        }        
        //перевантаження оператора ділення
        public static Vector operator /(Vector left, int divisor)
        {
             Vector result = new Vector();
             result.r = left.r/divisor;
             result.f = left.f/divisor;
             return result;
        }
        //перевантаження оператора додавання
        public static Vector operator +(Vector left, Vector other)
        {
             Vector result = new Vector();
             result.r = left.r + other.r;
             result.f = left.f + other.f;
             return result;
        }
    }
    
    public class Program
    {
        static public void  Main(string[] args)
        {
            Console.WriteLine("\nЛабораторна №4 ООП Павлик Вікторії ІС-93");
            Vector v1 = new Vector();
            Vector v2 = new Vector(6,45);
            Vector v3 = new Vector(v2);
            Console.WriteLine("\nВектор 1:");
            v1.Print();
            Console.WriteLine("\nВектор 2:");
            v2.Print();
            Console.WriteLine("\nВектор 3:");
            v3.Print();
            Console.WriteLine("\n\nВектор 2 зменшений у два рази: ");
            v2 = v2/2;
            v2.Print();
            Console.WriteLine("\n\nВектор 3 розвернутий на 45 градусів:");
            v3.Rotate(45);
            v3.Print();
            Console.WriteLine("\n\nВектор 1 як результат додавання вектора 2 та вектора 3:");
            v1 = v2 + v3;
            v1.Print();
        }
    }
}