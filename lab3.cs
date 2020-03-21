using System;

namespace laba3
{
    class Array 
    {
            public int length = 5;
            private int[] array = new int[]{1,2,3,4,5};
    //індексатор, що запобігає порушенню границі масиву
            public int this[int index] 
            {
                get 
                {
                    if((index >= 0)&&(index <= length))
                    {
                         return array[index];
                    }
                }
                set 
                { 
                    if((index >= 0)&&(index <= length))
                    {
                        array[index] = value;
                    } 
                }
            }
    //властивість, доступна для читання закритого елементу-даного,
    //що контролює доступ до змінної довжини масиву
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
    }
    class Program
    {
        static void main(string[] args)
        {
            Console.WriteLine("\nЛабораторна №3 ООП Павлик Вікторії ІС-93");
            Array arr = new Array();
            //завдяки індексаторам маємо доступ до елементів масиву
            //і не порушуємо границі масиву
            Console.WriteLine(arr[2]);
            //завдяки властивості маємо доступ до закритого елементу-даного(довжини)
            arr.Length = 7;
            Console.ReadKey();
        }
    }
}