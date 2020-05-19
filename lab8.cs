using System;
namespace laba8
{
    class Car
    {
        private bool move;  // змінна, що вказує на рух
        private int fuel;  //  змінна, що вказує на рівень палива
        public Car(){move = false; fuel = 0;}  // конструктор за замовчуванням
        public Car(bool mov, int num){move = mov; fuel = num;}  // конструктор з параметрами
        public void setMove(bool mov){move = mov;}  // встановити рух
        public bool getMove(){return move;}  // отримати інформацію про рух
        public void setFuel(int num){fuel = num;}  // встановити рівень пального
        public int getFuel(){return fuel;}  // отримати інформацію про рівень пального
        public void StartMoving(){move = true;  // початок руху
                                  Console.WriteLine("Машина почала рух");}
        public void EndMoving(){move = false;  // кінець руху
                               Console.WriteLine("Машина завершила рух");}
        public void IsMoving()  
        {Console.WriteLine("Машина рухається");}
        public void NotMoving()  
        {Console.WriteLine("Машина стоїть");}
        public int FillCar(int num){return fuel += num;}  // заправити машину
        public int FuelWaste(int num){return fuel -= num;}  // витрата палива
    }
     public class Program
     {
         delegate void MoveInfo();  
         delegate int FuelLevel(int num);
         static public void Main(string[] args)
         {
             Car car = new Car(true, 20);

             MoveInfo info;  // делегат для з'ясування стану машини
             if (car.getMove()==true)
                 info = car.IsMoving;
             else
                 info = car.NotMoving;

            if (info != null)
                info();  // отримання інформації про стан машини

            FuelLevel level;  // делегат для визначення рівня пального
            if (car.getFuel()<5)
                level = car.FillCar;
            else
                level = car.FuelWaste;

            if (level != null)
                level(5);  // заправити машину або витратити пальне
            Console.WriteLine("Рівень пального ");
            Console.WriteLine(car.getFuel());
         }
     }
}