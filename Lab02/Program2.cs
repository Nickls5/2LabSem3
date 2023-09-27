using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        static void Main()
        {
            Vehicle veh = new Vehicle(10, 10, 40000, 80, 1987);
            veh.ShowInfo();
            Console.WriteLine();

            Plane pln = new Plane(40, -5, 600000, 800, 2007, 6000, 30);
            pln.ShowInfo();
            Console.WriteLine();

            Car car = new Car(3, 5, 50000, 150, 2015, "Sedan");
            car.ShowInfo();
            Console.WriteLine();

            Ship ship = new Ship(4, 4, 300000, 70, 2000, "Sochi", 40);
            ship.ShowInfo();
            Console.WriteLine();


        }
    }
    public class Vehicle
    {
        private double  CoordinateX, CoordinateY;
        private int Price;
        private int Speed;
        private int YearOfManufact;

      

        public Vehicle(double x, double y, int price, int speed, int yearofmanufact)
        {
            this.CoordinateX = x;
            this.CoordinateY = y;
            this.Price = price;
            this.Speed = speed;
            this.YearOfManufact = yearofmanufact;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Координаты: {CoordinateX} {CoordinateY}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Скорость: {Speed}");
            Console.WriteLine($"Год выпуска: {YearOfManufact}");
        }

    }

    public class Plane : Vehicle
    {
        private double Height;
        private int PassangersNum;

        public Plane (double x, double y, int price, int speed, int yearofmanufact, double height, int passnum)
            : base(x, y, price, speed, yearofmanufact)
        {
            
                this.Height = height;
                this.PassangersNum = passnum;
            
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Число пассажиров: {PassangersNum}");
        }
    }

    public class Car : Vehicle
    {
        private string Model;

        public Car(double x, double y, int price, int speed, int yearofmanufact, string model) :
            base(x, y, price, speed, yearofmanufact)
        {
             this.Model =  model;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Модель: {Model}");
        }
    }

    public class Ship : Vehicle
    {
        private string Port;
        private int PassengersNum;

        public Ship (double x, double y, int price, int speed, int yearofmanufacture, string port, int passengersNum) :
            base (x,y,price, speed, yearofmanufacture)
        {
            this.Port = port;
            this.PassengersNum = passengersNum;
        } 
    }

}
