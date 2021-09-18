//第三章第一/二题
using System;

namespace NO6
{

    abstract class Shape
    {
        public virtual double PrintArea() {
            Console.WriteLine("图形的面积是：0");
            return 0;
        }
        public virtual bool IsShape() {
            return false;
        }
    }


    class Rectangle : Shape
    {

        public double height
        {
            get;set;
        }
        public double width
        {
            get;set;
        }
        public Rectangle(double height,double width)
        {
            this.height = height;
            this.width = width;
        }

        public override bool IsShape()
        {
            return height > 0 && width > 0;
        }

        public override double PrintArea()
        {
            Console.WriteLine("长方形的面积是："+ height * width);
            return height * width;
        }

    }

    class Square : Shape
    {
        public double side
        {
            get;set;
        }
        public Square(double side)
        {
            this.side = side;
        }
        public override bool IsShape()
        {
            return side>0;
        }

        public override double PrintArea()
        {
            Console.WriteLine("正方形的面积是：" + side * side);
            return side * side;
        }
    }

    class Triangle:Shape
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }

        public Triangle(double a,double b,double c)
        {

            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
        }
        public override bool IsShape()
        {
            return sideA > 0 && sideB > 0 && sideC > 0 && sideA + sideB > sideC && sideC + sideB > sideA && sideA + sideC > sideB;
        }

        public override double PrintArea()
        {
            double p = (sideA + sideB + sideC) / 2;
            Console.WriteLine("三角形的面积是：" + Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)));
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    }

    class Circle : Shape
    {
        public double radius
        {
            get; set;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override bool IsShape()
        {
            return radius > 0;
        }

        public override double PrintArea()
        {


            Console.WriteLine("圆形的面积是：" + Math.PI * radius * radius);
            return Math.PI * radius * radius;

        }
    }
    class ShapeFactory
    {
        public static Shape GetShape(int index,double a,double b,double c)
        {
            Shape shape = null;
            switch (index)
            {
                case 0:

                    shape = new Triangle(a,b,c);
                    break;
                case 1:
                    
                    shape = new Square(a);
                    break;
                case 2:
                   
                    shape = new Circle(a);
                    break;
                case 3:

                    shape = new Rectangle(a,b);
                    break;
                default:break;
            }
            return shape;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            double totalArea=0;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"第{i+1}个图形");
                Random random = new Random();
                int n = random.Next(0, 4);
                Random random_A = new Random();
                int a = random.Next(0, 10);
                Random random_B = new Random();
                int b = random.Next(0, 10);
                Random random_C = new Random();
                int c = random.Next(0, 10);
                Console.WriteLine($"a:{a},b:{b},c:{c}");
                Shape shape= ShapeFactory.GetShape(n,a,b,c);
                if (shape != null && shape.IsShape())
                    totalArea += shape.PrintArea();
                else {
                    i--;
                    Console.WriteLine("非法数据");
                }
                    
            }

            Console.WriteLine("总面积为："+totalArea);
        }
    }
}
