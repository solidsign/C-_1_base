using System;

namespace C_2_base
{
    // Необходимо реализовать объектную модель геометрических фигур (прямоугольник, тругольник, круг).
    // Ко всем фигурам должно быть возможно осуществить доступ по одному имени 
    // Через это имя должно быть возможно получить доступ к площади и периметру фигур
    // Все числа пусть имееют тип double
    abstract class Shape
    {
        public abstract double Area { get; }
        public abstract double Perimetr { get; }
    }

    class Triangle : Shape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area
        {
            get
            {
                double p = Perimetr;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public override double Perimetr
        {
            get
            {
                return a + b + c;
            }
        }
    }

    class Circle : Shape
    {
        private double radius;
        private const double PI = 3.14;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get 
            { 
                return PI * radius * radius;
            }
        }
        public override double Perimetr
        {
            get
            {
                return 2 * PI * radius;
            }
        }
    }

    class Rectangle : Shape
    {
        double a, b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Area
        {
            get
            {
                return a * b;
            }
        }
        public override double Perimetr
        {
            get
            {
                return 2 * a + 2 * b;
            }
        }
    }
}
