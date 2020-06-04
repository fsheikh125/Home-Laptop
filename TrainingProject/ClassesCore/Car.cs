using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public  class Car
    {
      

        //Members
        public string EngineType = "Diesel";
        public int NumberOfGears = 5;

        //Methods
        
        public void Start()
        {
            Console.WriteLine("The car started");
        }

        public void ChangeGear(int gearNumber)
        {
            Console.WriteLine("Changing gear to "+gearNumber);
        }

        public string ReturnCarKeys()
        {
            Console.WriteLine("Car stopped");
            string s = "Keys with black key chain";
            return s;
        }

        public double GetFuelAmount(double noOfLitres)
        {
            Console.WriteLine("Calculating cost ....");
            double totalAmount = noOfLitres * 1.28;
            return totalAmount;
           
        }


        public void Details()
        {
            Start();
        }


        public static void FillAirInTyres()
        {
            Console.WriteLine("filling air");
        }


    }
}
