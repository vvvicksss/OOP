using System;
namespace laba6
{
    class Problem
    {
        private int a;
        private int c;
        private int d;
        public Problem()
        {
            a = 1;
            c = 1;
            d = 0;
        }
        public Problem(int a, int c, int d)
        {
            this.a = a;
            this.c = c;
            this.d = d;
        }
        public void setA(int num){this.a = num;}
        public void setC(int num){this.c = num;}
        public void setD(int num){this.d = num;}
        public int getA(){return a;}
        public int getC(){return c;}
        public int getD(){return d;}
        public double Numerator()
        {
            try
            {
                double solvedA;
                solvedA = SquareRoot(a);
                return 2*c - d + solvedA;
            }
            catch(Exception)
            {
                Console.WriteLine("Error! Negative number!\nSquare root is not solved");
				return 2*c - d;
            }
            finally
            {
                Console.WriteLine("Solving problem without value of square root");
            }
        }
        public double SquareRoot(int num)
        {
            if (num < 0)
                 throw new Exception("Negative number under square root!");
            return Math.Sqrt(23*num);
        }
        public double Denominator()
        {
            if (a == 4)
            {
                throw new Exception("This value leads to division by zero!");
            }
            return a/4 - 1;
        }
        public double ProblemSolution()
        {
            try
            {
                return Numerator()/Denominator();
            }
            catch(Exception)
            {
                Console.WriteLine("Error! Division by zero");
				return Numerator();
            }
            finally
            {
                Console.WriteLine("Instead division by 1");
            }
        }
    }
    public class Program
    {
        static public void Main(string[] args)
        {
            int[] numbers = new int[50];
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rand.Next(-100, 100); 

            for (int i = 0; i < numbers.Length; i=i+1)
            {
                Problem prob = new Problem(numbers[i], numbers[i+1], numbers[i+2]);
                Console.WriteLine(prob.ProblemSolution());
            }
        }
    }
}