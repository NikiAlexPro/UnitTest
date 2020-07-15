using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lab_7
{

    
    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        
    }
    
    public class Point
    {
        double x, y;
        public static double xCheck;
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                if(value >0 && value <11)
                {
                    x = value;
                }
                else if(value < 1 || value > 10)
                {
                    throw new MyException();
                }
                else
                    throw new MyException();
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value > 0 && value < 11)
                {
                    y = value;
                }
                else if (value < 1 || value > 10)
                {
                    throw new MyException();
                }
                else
                    throw new MyException();
            }
        }
        public Point(double x1, double y1)
        {
            X = x1;
            Y = y1;
        }

        public static bool CheckIntersectionOfTwoLineSegment(Point p1, Point p2, Point p3, Point p4)
        {
            if(p2.x < p1.x)
            {
                Point tmp = p1;
                p1 = p2;
                p2 = tmp;
            }
            if (p4.x < p3.x)
            {
                Point tmp = p3;
                p3 = p4;
                p4 = tmp;
            }
            if (p2.x < p3.x)
                return false;
            if((p1.x - p2.x == 0) && (p3.x - p4.x == 0))//Условие вертикальности отрезков
            {
                if(p1.x == p3.x)
                {
                    if (!((Math.Max(p1.y, p2.y) < Math.Min(p3.y, p4.y)) || (Math.Min(p1.y, p2.y) > Math.Max(p3.y, p4.y))))
                    {
                        return true;
                    }
                }
                return false;
            }
            //Коэф. Уравнений, содержащий отрезки
            //Если 1 отрезок вертикальный
            if (p1.x - p2.x == 0)
            {
                //найдем Xa, Ya - точки пересечения прямых
                double Xa_1 = p1.x;
                double A2_1 = (p3.y - p4.y) / (p3.x - p4.x);
                double b2_1 = p3.y - A2_1 * p3.x;
                double Ya_1 = A2_1 * Xa_1 + b2_1;
                if(p3.x <= Xa_1 && p4.x >= Xa_1 && Math.Min(p1.y,p2.y) <= Ya_1 && Math.Max(p1.y, p2.y) >= Ya_1)
                {
                    return true;
                }
                return false;
            }
            
            //Если второй отрезок вертикальный
            if (p3.x - p4.x == 0)
            {
                //найдем Xa, Ya - точки пересечения прямых
                double Xa_2 = p3.x;
                double A1_2 = (p1.y - p2.y) / (p1.x - p2.x);
                double b1_2 = p1.y - A1_2 * p1.x;
                double Ya_2 = A1_2 * Xa_2 + b1_2;
                if (p1.x <= Xa_2 && p2.x >= Xa_2 && Math.Min(p3.y, p4.y) <= Ya_2 && Math.Max(p3.y, p4.y) >= Ya_2)
                {
                    return true;
                }
                return false;
            }
            //Оба отрезка невертикальные
            double A1 = (p1.y - p2.y) / (p1.x - p2.x);
            double A2 = (p3.y - p4.y) / (p3.x - p4.x);
            double b1 = p1.y - A1 * p1.x;
            double b2 = p3.y - A2 * p3.x;
            if(A1 == A2)
            {
                return false; //Отрезки параллельны
            }
            double Xa = (b2 - b1) / (A1 - A2);
            xCheck = Xa;
            //Если точка Xa находится вне пересечения проекций на ось X
            if ((Xa < Math.Max(p1.x, p3.x)) || (Xa > Math.Min(p2.x, p4.x)))
            {
                return false;
            }
            else//Если внутри пересечения проекций на ось X
                return true;
        }
    }
    class Program
    {
        public static void Main()
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point(3, 3);
            Point p3 = new Point(4, 2);
            Point p4 = new Point(1, 4);
            Console.WriteLine(Point.CheckIntersectionOfTwoLineSegment(p1, p2, p3, p4));
            Console.WriteLine($"\nТочка пересечения по оси X = {Point.xCheck}");
            Console.ReadLine();
        }
    }
}
