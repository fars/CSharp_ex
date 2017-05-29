using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        private Singleton()
        {
        }

        public static Singleton getInstance()
        {
            return instance;
        }
    }

    public class Engine
    {
        public Engine(int cylindres)
        {

        }

        public void Start()
        {

        }

        public void Stop()
        {

        }

    }

    public class Vehicle
    {
        protected double Speed = 0;

        public Vehicle( double speed )
        {
            Console.WriteLine("Vehicle created");
            Speed = speed;
        }

        ~Vehicle()
        {
            Console.WriteLine("Vehicle destroyed");
        }

        public double GetSpeed()
        {
            return Speed;
        }

    }

    public class Sedan : Vehicle
    {
        private Engine _engine = new Engine(5);

        public Sedan(): this(0)
        {
            Console.WriteLine("Megane Sedan Baklajan");
        }

        public Sedan(double speed) : base(speed)
        {
            Console.WriteLine("Megane Sedan Baklajan");
        }

        public Sedan(string str) : this(40)
        {
            Console.WriteLine("Megane Sedan Baklajan");
        }

        public void ChangeSpeed()
        {
            Speed = Speed + 40;
        }

        private void StartEngine()
        {
            Console.WriteLine("StartEngine");
        }

        ~Sedan()
        {
            Console.WriteLine("Sedan destroyed");
        }
}

    class Toyota : Sedan
    {

    }

    //---------------------------------------------------------------------------------------

    public class Adress
    {
        private int _appartment;
        public string _street;
        public Adress(int ap, string street)
        {
            _appartment = ap;
            _street = street;
        }
    }

    public class Person
    {
        private Adress _adress;
        public Person(Adress adress)
        {
            _adress = adress;
            Console.WriteLine("Adrr str. {0}", _adress._street);
        }
    }
    //--------------------------------------------------------


    public interface IDrawable
    {
        void Drawing(int i);
        void DrawInColours();
    }

    public interface ICalculatable
    {
        double GetSquare();
    }

    enum Colors
    {
        Red,
        Green,
        Blue
    }

    public class CircleInstrument
    {
        public void DrawRoundShape(int rdius)
        {

        }
    }

    public abstract class Shape
    {

        protected Shape()
        {
            Console.WriteLine("Shape created");
        }
        public abstract void Draw();

        public void SayHello()
        {
            Console.WriteLine("Shape say hello");
        }

    }

    public sealed class Square : Shape, IDrawable, ICalculatable
    {
        private double _a = 10;
        private double _b = 20;


        public Square()
        {

        }

        public Square(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public void SetA(double a)
        {
            _a = a;
        }

        public void SetB(double b)
        {
            _b = b;
        }

        public override void Draw()
        {
            Console.WriteLine("Square Draw()");
        }

        public void Drawing(int i)
        {
            Console.WriteLine("Circle IDrawable() {0}", i);
        }

        public void DrawInColours()
        {
            Console.WriteLine("DrawInColours");
        }

        public double GetSquare()
        {
            return _a*_b;
        }

    }


    public class Circle : Shape, IDrawable, ICalculatable
    {
        private double _radius = 10;
        public Circle()
        {

        }

        public Circle(double radius)
        {
            _radius = radius;
        }

        public void SetRadius(double radius)
        {
            _radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Circle Draw()");
        }
        public void Drawing(int i)
        {
            Console.WriteLine("Circle IDrawable() {0}", i);
        }

        public void DrawInColours()
        {
            Console.WriteLine("DrawInColours");
        }

        public double GetSquare()
        {
            return 2 * Math.PI * _radius;
        }
    }





    class Program
    {
        static void Drawing(IDrawable drawingFigure)
        {
            drawingFigure.Drawing(5);
            drawingFigure.DrawInColours();
        }

        static void Main(string[] args)
        {

            Shape[] collection = new Shape[3];
            collection[0] = new Circle(20);
            collection[1] = new Square(30,40);
            collection[2] = new Circle(50);

            foreach (var shp in collection)
            {
                if (shp is Square)
                {
                    Square c = (Square) shp;
                    c.DrawInColours();
                }

                Circle cl = (shp as Circle);
                if (cl != null)
                {
                    cl.Draw();
                }
            }

            Circle clr = new Circle();
            Shape fig = (Shape) clr;
            fig.SayHello();



        }
    }
}
