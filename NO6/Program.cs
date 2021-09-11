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
            if (height > 0 && width > 0)
                return true;
            return false;
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
            if (side> 0)
                return true;
            return false;
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
            if (sideA+sideB > sideC&& sideC + sideB > sideA&& sideA + sideC > sideB)
                return true;
            return false;
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
            if (radius > 0)
                return true;
            return false;
        }

        public override double PrintArea()
        {


            Console.WriteLine("圆形的面积是：" + Math.PI * radius * radius);
            return Math.PI * radius * radius;

        }
    }
    class ShapeFactory
    {
        public static Shape GetShape(int index)
        {
            Shape shape = null;
            switch (index)
            {
                case 0:
                    Console.WriteLine("请分别输入三角形三条边：");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    shape = new Triangle(a,b,c);
                    break;
                case 1:
                    Console.WriteLine("请输入正方形的边：");
                    double side = double.Parse(Console.ReadLine());
                    shape = new Square(side);
                    break;
                case 2:
                    Console.WriteLine("请输入圆形半径：");
                    double radius = double.Parse(Console.ReadLine());
                    shape = new Circle(radius);
                    break;
                case 3:
                    Console.WriteLine("请分别输入长方形的长和宽：");
                    double height = double.Parse(Console.ReadLine());
                    double width = double.Parse(Console.ReadLine());
                    shape = new Rectangle(height,width);
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
                Shape shape= ShapeFactory.GetShape(n);
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
