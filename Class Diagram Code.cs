using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


    abstract class Vehicle //its a kind of general class
    {
        protected Engine EngN;
        protected AC AcN;
        public Vehicle(Engine e, AC Ac)
        {
            this.EngN = e;
            this.AcN = Ac;

        }
        public Vehicle(Engine e)
        {
            this.EngN = e;
        }
        abstract public void display();
        public void disply(drive d)
        {
            d.timing();
        }

    }
    class LandVehicle : Vehicle
    {
        private int model;
        public LandVehicle(Engine eng2, AC ac2, int mod1) : base(eng2, ac2)
        {
            this.model = mod1;
        }
        public override void display()
        {
            Console.WriteLine("Number of engine in car :" + EngN);
            Console.WriteLine("Number of ac in car: " + AcN);
        }


    }
    class othervehicle : Vehicle
    {
        private string name;
        public othervehicle(Engine eng3, AC ac3, string name) : base(eng3, ac3)
        {

            this.name = name;
        }
        public override void display() //override method bcz vehacle class also have same method
        {
            Console.WriteLine("Number of engine in car :" + EngN);
            Console.WriteLine("Number of ac in car: " + AcN);
        }
    }

    class Engine
    {
        protected int TotalEngine;
        public Engine(int num)
        {
            this.TotalEngine = num;
        }
        public void display()
        {
            Console.WriteLine("The number of engine : " + TotalEngine);
        }

    }
    class AC
    {
        protected int TotalAc;
        public AC(int num)
        {
            this.TotalAc = num;
        }
        public void display()
        {
            Console.WriteLine("The number of AC : " + TotalAc);
        }
    }


    public class drive
    {
        protected string drive_slot;
        
        public drive(string slot)
        {
            this.drive_slot = slot;
        }
        public virtual void timing()
        {
            Console.WriteLine("The slot of driving is : " + drive_slot);
        }

    }
    class trip : drive
    {
        public string drive_slots;
        private int trips;
        public trip(string driving_slot, int t) : base(driving_slot)
        {
            this.trips = t;
        }
        public override void timing()
        {
            Console.WriteLine("The slot of driving is : " + drive_slot);
            Console.WriteLine("The Complete trips are  : " + trips);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Engine e1 = new Engine(2);
            AC ac1 = new AC(1);
            LandVehicle Veh1 = new LandVehicle(e1, ac1,321);
            trip tr = new trip("Morning", 3);
            drive dr = new drive("Evening");
            Veh1.display();
            Veh1.disply(dr);
            dr.timing();
            tr.timing();
            e1.display();
            ac1.display();
            Console.WriteLine("\n ---other vehicle--\n");
            Engine e2 = new Engine(1);
            AC ac2 = new AC(2);
            othervehicle Veh2 = new othervehicle(e1, ac1, "honda 123");
            trip tr2 = new trip("Morning", 3);
            drive dr2 = new drive("Evening");
            Veh2.display();
            Veh2.disply(dr2);
            dr2.timing();
            tr2.timing();
            e2.display();
            ac2.display();
            Console.ReadLine();
            
        }

    }
}
