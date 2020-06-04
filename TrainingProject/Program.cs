

using Com.Casio;
using SeleniumTraining;
using System;
using System.IO;
using System.Linq;
using TrainingProject.ClassesCore;
using TrainingProject.Utilities;

namespace TrainingProject
{
   public  class Program
    {

        public static readonly  double pi = 3.14;
       public  static void Main(string[] args)


        {

            //Console.WriteLine("from coomad line : "+ args[0]+ "   >>" +args[1]);
            // Ex01_DataTypes.Demo();
            //Ex02_ControlStatements.Demo();
            // Ex02_ControlStatements.NestedIfElseDemo();
            //Ex02_ControlStatements.SwitchDemo();
            //Ex03_Iterations.WhileDemo();
            // Ex03_Iterations.DoWhileDemo();
            //Ex03_Iterations.ForDemo();
            //Ex04_Arrays.ArrayDemo();
            //Ex04_Arrays.ListDemo();

            // Ex05 Cars Classes and Methods
            //Car myCar = new Car();  // instatiation of car object
            //Car bmw = new Car();
            //Console.WriteLine("Engine type is "+ myCar.EngineType);

            //myCar.Start();
            //myCar.ChangeGear(2);
            //string abc = myCar.ReturnCarKeys();
            //Console.WriteLine(abc);
            //double cost= myCar.GetFuelAmount(41.5);
            //Console.WriteLine("£"+cost);

            //Ex06 Constructors 
            //Bike honda = new Bike();
            //Bike suzuki = new Bike("RX 100");
            //suzuki.Details();

            //Ex07 home Work Method Overloading
            //Addition addition = new Addition();
            //addition.add(2, 7);
            //addition.add(1, 5, 9);

            //Ex08 Inheritance demo
            //A a = new A();
            //Console.WriteLine("A's first name "+a.fname);
            //a.Hobbies();

            //B b = new B();
            //Console.WriteLine("B's first name " + b.fname);
            //Console.WriteLine("B surnmae is "+b.sname);
            //b.Hobbies();
            //b.demoThisAndBase();

            //Ex09 namespace and using keyword
            // Calc c = new Calc();
            // c.Add();


            //Ex10 static
            // StaticDemo sdemo = new StaticDemo(); this is not needed for accessing static members and methods
            //StaticDemo.SMethod();
            // Console.WriteLine(StaticDemo.i);

            //StaticDemo sdemo = new StaticDemo();
            // sdemo.NSmethod();

            //readonly
            //pi = 9.99; // cannot chnage value as its readonly

            //Console.WriteLine("pi value is "+pi);

            //abstract
            // Shape shape = new Shape();  abstarct classes cannot be instantiated.
            //Triangle triangle = new Triangle();
            //triangle.Area(10, 20);

            //interface
            //IBird parrot1 = new Parrot();
            //  parrot1.Fly();

            //Parrot parrot = new Parrot();
            //parrot.Eat();
            //parrot.Fly();

            //Exception

            // ExceptionDemo ed = new ExceptionDemo();
            //// ed.EDemo();

            // // Data Encapsulation
            // DataEncapsulation de = new DataEncapsulation();
            // de.Email = "a@b.com";
            // Console.WriteLine(de.Email);

            // //Dictonary demo
            //DictionaryDemo.Demo();

            // //String MAnipulation
            // string s1 = "My name is khan";
            // int l1= s1.Length;
            // Console.WriteLine(l1);
            // Console.WriteLine(s1.Substring(3, l1-3));
            // Console.WriteLine(s1.Trim());

            // string s2 = "My NAME IS Khan";
            // Console.WriteLine(s1.ToLower().Equals(s2.ToLower()));

            // Console.WriteLine(Utils.ReverseString(s1));

            // Utils.writeToFile("C:/Pros/abcde.txt", s1);

            // Umar umar = new Umar();
            // umar.ChangeDetails();
            // //umar.anotherMethod();

            // Console.WriteLine("************");
            // Umar.GetCurrentDate();
            // Console.WriteLine("**************");

            // Console.WriteLine(Irfan.GenerateNumber10());
            // Console.WriteLine(Irfan.RandomDate());
            // Console.WriteLine(Irfan.TimeDate());


            House myHouse = new House();
            myHouse.OpenDoor();
           
            House asadMAnsion = new House();
            asadMAnsion.OpenDoor();
            
            string x = "Master Bedroom";
            myHouse.CloseDoor(x);

            int bedrooms =myHouse.getNumberOfBedrooms();
            Console.WriteLine(bedrooms);

            Console.WriteLine(myHouse.getNumberOfBedrooms());

            int noofbedrooms = 8;
            int rent = myHouse.calcuateHouseRent(6);
            Console.WriteLine(rent);

            Car ferrari = new Car();
            ferrari.Start();
            Console.WriteLine(House.CarParking(1));
            Console.WriteLine("*******************");
            
            House myhouse = new House();

            myhouse.OpenDoor();
            
        }
    }
    
}
