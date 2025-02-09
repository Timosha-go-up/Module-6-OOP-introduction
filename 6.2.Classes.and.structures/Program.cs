using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2.Classes.and.structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте класс Rectangle для представления прямоугольников удовлетворяющий следующим требованиям:
            //Класс должен содержать целочисленные поля для сторон a и b.
            //Класс должен содержать метод Square, возвращающий площадь прямоугольника(произведение сторон).
            //Класс должен содержать 3 конструктора: с 2 параметрами, 
            //когда a != b, с 1 параметром, когда a == b, и конструктор без параметров по умолчанию, в котором стороны будут заполняться как a = 6, b = 4.


            Rectangle rectangle = new Rectangle();

            Console.WriteLine(rectangle.Square());

            Console.ReadKey();
        }
    }

    class Human
    {
        // Поля класса
        public string name;
        public int age;

        // Метод класса
        public void Greetings()
        {
            Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
        }

        // Конструктор 1
        public Human()
        {
            name = "Неизвестно";
            age = 20;
        }
        // Конструктор 2
        public Human(string n)
        {
            name = n;
            age = 20;
        }
        // Конструктор 3
        public Human(string n, int a)
        {
            name = n;
            age = a;
        }


    }

    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "black";

            cost = 100;
        }

        public Pen(string Color, int Cost)
        {
            cost = Cost;
            color = Color;
        }
    }

    class Rectangle
    {
        public int a;
        public int b;

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        public Rectangle(int x, int y)
        {
            a = x;
            b = y;
        }

        public Rectangle(int x)
        {
            a = b = x;
        }

        public int Square()
        {
            return a * b;
        }
    }
}
