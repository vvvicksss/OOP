using System;

namespace laba5
{
    class Line
    {
        private double coordBeginX;
        private double coordBeginY;
        private double coordEndX;
        private double coordEndY;

        public Line()
        {
            coordBeginX = 0;
            coordBeginY = 0;
            coordEndX = 0;
            coordEndY = 0;
        }
        public Line(double x1, double y1, double x2, double y2)
        {
            coordBeginX = x1;
            coordBeginY = y1;
            coordEndX = x2;
            coordEndY = y2;
        }
        public double LineLength()
        {
            if(coordEndX&&coordEndY != 0 && coordBeginX&&coordBeginY != 0)
                return Math.Sqrt(Math.Pow((coordEndX - coordBeginX),2)+Math.Pow((coordEndY - coordBeginY),2));
            else
                return 0; 
        }
    }
    class LineSegment: Line
    {
        private double beginX;
        private double beginY;
        private double endX;
        private double endY;

        public LineSegment()
        {
            beginX = 0;
            beginY = 0;
            endX = 0;
            endY = 0;
        }
        public  LineSegment(double x1, double y1, double x2, double y2)
        {
            beginX = x1;
            beginY = y1;
            endX = x2;
            endY = y2;
        }
        public double Angle()
        {
            return (Math.Abs(endY - beginY))/(Math.Abs(endX - beginX));
        }
        public double getXbegin(){return beginX;}
        public double getYbegin(){return beginY;}
        public double getXend(){return endX;}
        public double getYend(){return endY;}
    }
    public class Program
    {
        static public void  Main(string[] args)
        {
            Console.WriteLine("\nЛабораторна №5 ООП Павлик Вікторії ІС-93");
            Console.WriteLine("\nУспадкування та поліморфізм класів");
            LineSegment lineSegm = new LineSegment(9, 13, 5, 3);
            Console.WriteLine($"\nКоординати початку відрізка: {lineSegm.getXbegin()} {lineSegm.getYbegin()}");
            Console.WriteLine($"\nКоординати кінця відрізка: {lineSegm.getXbegin()} {lineSegm.getYbegin()}");
            Console.WriteLine($"\nДовжина даного відрізка: {lineSegm.LineLength()}");
            Console.WriteLine($"\nТангенс кута з віссю OX: {lineSegm.Angle()}");
            double angle;
            angle = Math.Atan(lineSegm.Angle());
            Console.WriteLine($"\nКут з віссю OX: {angle}");
        }
    }
}