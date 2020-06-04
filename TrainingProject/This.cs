using Com.Casio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.ClassesCore;

namespace TrainingProject
{
    class This
    {

        public string add( string s1, string s2)
        {

            string x = s1 + s2;

            return x;
        }

        public void add (int a, string x)
        {

        }

        public void some()
        {

            var mycar1 = new Car();
            Car myCar = new Car();
            myCar.Start();
            myCar.ChangeGear(4);
            
            double z= myCar.GetFuelAmount(1.14);
            
            Car.FillAirInTyres();

            //baby steps
            string x = myCar.ReturnCarKeys();
            bool doesitContainBlack = x.Contains("black");
            Console.WriteLine(doesitContainBlack);

            // big steps
          
            Console.WriteLine(myCar.ReturnCarKeys().Contains("black"));

            Car mcar = new Car();
            mcar.Start();
            mcar.Start();
            mcar.Start();
            mcar.Start();

            Console.WriteLine(new Car().ReturnCarKeys().Length * 2);

            string lname = "khan";
            string s = "my name is " + lname + " and i live in blore"   ;

            var number = "123";
            Bike myBike = new Bike();
            // myBike.Bike();
            Bike xbike = new Bike("cd 100");

            Calc c = new Calc();
            


        }


    }
}
