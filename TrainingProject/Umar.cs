using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    public class Umar
    {
        public string model = "Ford";
        public int i = 10;

        public  void ChangeDetails()
        {
            Console.WriteLine(model);
            Console.WriteLine(i);
            i = 100;
            model = "Ferrai";
            Console.WriteLine("After Change"+ model);

            int x = 99;
            anotherMethod(x);
            Console.WriteLine(x);

        }

        public void anotherMethod(int s)
        {
            Console.WriteLine("caaling agter chnage details "+model);
            Console.WriteLine(i);
            s = s * 100;
            Console.WriteLine(s);
        }




        public static DateTime RandomDate()
        {
            Random gen = new Random();
            DateTime randomDate = DateTime.Today.AddDays(gen.Next(0, 30)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));
            //Console.WriteLine(randomDate);
            return randomDate;
        }



        public static string GetCurrentDate()
        {
            //Getdate dateAsString = new Getdate();
            string gd = DateTime.Now.ToString("ddMMyyyy HHMMss");
            return gd;

        }




        public static void AccessResourceFile()
        {
           // string a = Properties.Resources.suresh_string;
           // Console.WriteLine(a);

        }



        public static long Random4DigitNumber() //this includes random 6 digit number too
        {
            Random num = new Random();
            long num1 = num.Next(1000, 9999);
            long num2 = num.Next(1000000000, 2099999999);
            Console.WriteLine(num1 + " " + num2);
            return (num1 + num2);
        }






    }
}
