using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public  class Bike
    {
        public string Model;

        public  Bike()
        {
            Console.WriteLine("Default Constructor Exposed!!!");
        }

        public void Start()
        {
            Console.WriteLine("Bike started...");
        }
        public Bike(string modelx)
        {
            Model = modelx;
            Console.WriteLine("Constrtor of Model "+ modelx);
            Start();
        }

        public void Details()
        {
            Console.WriteLine("The bike Model is "+Model);
        }

         public static void m1()
        {

        }


    }
}
