using System;
namespace laba8
{
    class Car
    {
        private bool move;
        private int fuel;
        public Car(){move = false; fuel = 0;}
        public Car(bool mov, int num){move = mov; fuel = num;}
        public void setMove(bool mov){move = mov;}
        public bool getMove(){return move;}
        public void setFuel(int num){fuel = num;}
        public int getFuel(){return fuel;}
        public void StartMoving(){move = true;
                                  Console.WriteLine("Машина почала рух");}
        public void EndMoving(){move = false;
                               Console.WriteLine("Машина завершила рух");}
        public void IsMoving()
        {Console.WriteLine("Машина рухається");}
        public void NotMoving()
        {Console.WriteLine("Машина стоїть");}
        public int FillCar(int num){return fuel += num;}
        public int FuelWaste(int num){return fuel -= num;}
    }
     public class Program
     {
         delegate void MoveInfo();
         delegate int FuelLevel(int num);
         static public void Main(string[] args)
         {
             Car car = new Car(true, 20);

             MoveInfo info;
             if (car.getMove()==true)
                 info = car.IsMoving;
             else
                 info = car.NotMoving;

            if (info != null)
                info();

            FuelLevel level;
            if (car.getFuel()<5)
                level = car.FillCar;
            else
                level = car.FuelWaste;

            if (level != null)
                level(5);
            Console.WriteLine("Рівень пального ");
            Console.WriteLine(car.getFuel());
         }
     }
}