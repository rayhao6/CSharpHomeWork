using System;

namespace work3
{
    public abstract class Shape
    {
        public String getName()
        {
            return this.GetType().Name;
        }
        public abstract double getArea();
        public abstract bool legal();
    }
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override bool legal()
        {
            if (height > 0 && width > 0)
            {
                return true;
            }
            else return false;
        }
        public override double getArea()
        {
            if (legal())
            {
                return width * height;
            }
            else
            {
                Console.WriteLine("invalid");
                return 0;
            }
        }

    }
    public class Triangle : Shape
    {
        private double width1, width2, width3;
        public Triangle(double width1, double width2, double width3)
        {
            this.width1 = width1;
            this.width2 = width2;
            this.width3 = width3;
        }

        public override bool legal()
        {
            double sum3 = width1 + width2;
            double sum1 = width2 + width3;
            double sum2 = width3 + width1;
            if (width1 >= sum1 || width2 >= sum2 || width3 >= sum3)
            {
                return false;
            }

            else return true;
        }
        public override double getArea()
        {
            if (legal())
            {

                double p = (width1 + width2 + width3) / 2;
                return Math.Sqrt(p * (p - width1) * (p - width2) * (p - width3));
            }
            else
            {
                Console.WriteLine("invalid input");
                return 0;
            }
        }
    }

    public class Square : Shape
    {
        private double width;
        public Square(double width)
        {
            this.width = width;
        }

        public override bool legal()
        {
            if (width > 0)
            {
                return true;
            }
            else return false;
        }

        public override double getArea()
        {
            return width * width;
        }

    }

    public class ShapeFactory
    {
        public static Shape getPolygen(double x, double y, double z )
        {
            Shape example = null;
            if (z == 0)
            {
                if (y==0)
                {
                    example = new Square(x);
                }
                else if (y != 0) { example = new Rectangle(x, y); }
            }
            if (z != 0)
            {
                if (y == 0)
                {
                    example = new Rectangle(x, z);
                }
                if (y != 0)
                {
                    example = new Triangle(x,y,z);
                }
            }
            return example;
        }



        static void Main(string[] args)
        {
            Random rnd = new Random();
            double x;
            double y=0;
            double z=0;
            Shape test = null;
            int i = 0;
            int k = 1;
            while (i < 10)
            {
                x = rnd.Next(1, 10);
                if (rnd.Next(0, 2) == 0)
                {
                    y = rnd.Next(1, 10);
                }
                if (rnd.Next(0, 2) == 1)
                {
                    int m = (int)(x + y-1);
                    if ((x - y) > 0)
                    {
                         k = (int)(x - y + 1);
                    }
                    else
                    {
                        k = (int)(y -x + 1);
                    }
                    int n = (int)(x + y - 1);
                    z = rnd.Next(k, m);
                }
                    test = ShapeFactory.getPolygen(x, y, z);
                    Console.WriteLine(test.getArea());
          
                ++i;
            }


        }
    }
}
            


