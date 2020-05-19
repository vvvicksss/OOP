using System;
namespace laba8
{
    class Car
    {
        public delegate void CarHandler(string message);  // делегат для події
        public event CarHandler Notify;  // визначення події
        private bool move;  // змінна, що вказує на рух
        private int fuel;  //  змінна, що вказує на рівень палива
        public Car(){move = false; fuel = 0;}  // конструктор за замовчуванням
        public Car(bool mov, int num){move = mov; fuel = num;}  // конструктор з параметрами
        public void setMove(bool mov){move = mov;}  // встановити рух
        public bool getMove(){return move;}  // отримати інформацію про рух
        public void setFuel(int num){fuel = num;}  // встановити рівень пального
        public int getFuel(){return fuel;}  // отримати інформацію про рівень пального
        public void StartMoving()  // початок руху
        {
            move = true;  
            Notify?.Invoke("Машина почала рух");  // виклик події
        }
        public void EndMoving()  // кінець руху
        {
            move = false;  
            Notify?.Invoke("Машина завершила рух");  // виклик події
        }
        public int FillCar(int num)  // заправити машину
        {
            fuel += num;
            Notify?.Invoke($"Машину заправили на: {num}");  // виклик події
        }  
        public int FuelWaste(int num)  // витрата палива
        {
            if (fuel >= num)
            {
                fuel -= num;
                Notify?.Invoke($"Витрачено палива: {num}");  // виклик події
            }
            else
            {
                Notify?.Invoke($"Недостатньо палива. Рівень палива: {num}");  // виклик події
            }
        }  
    }
     public class Program
     {
         static public void Main(string[] args)
         {
             Car car = new Car(true, 20);
             car.Notify += DisplayMessage; // додаємо обробник події
             
             car.StartMoving();
             car.EndMoving();
             car.FillCar(10);
             Console.WriteLine($"Рівень палива: {car.fuel}");
             car.FuelWaste(20);
             Console.WriteLine($"Рівень палива: {car.fuel}");
         }
     }
}