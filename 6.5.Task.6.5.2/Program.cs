using System;

namespace _6._5.Task._6._5._2
{
    internal class Program
    {
        //Опишите классы C# для следующих геометрических объектов: треугольник, круг, квадрат.
        // В классах нужно объявить поля для длин сторон(радиус) и методы для получения площади и периметра(длины окружности) без их реализации и без конструкторов.

        static void Main(string[] args)
        {

            Triangle triangle = new Triangle();   
            
            Console.WriteLine("Triengle: {0:0.##}", triangle.Square(2, 2, 2));

            Circle circle = new Circle();

            Console.WriteLine("Circle:   {0:0.##}", circle.Square(2));

            Quadrate quadrate = new Quadrate();
            Console.WriteLine("Quadrate: {0:0.##}",quadrate.Square(2, 4));

        }

        class Triangle
        {
            public int x;
            public int y;
            public int z;

            public double Square(int x, int y, int z)
            {
                int rez = (x + y + z) / 2;
                rez *= (rez - x) * (rez - y) * (rez - z);
                double result = Math.Sqrt(rez);

                return result;
            }

        }

        class Circle
        { 
            public int R;

            public double Square(int r) 
            {
                return r * r * 3.14;
            }
        }

        class Quadrate
        {
            public int a;
            public int b;
            public int Square(int a, int b)
            { return a * b; }
        
        }

       

        



    }
}
