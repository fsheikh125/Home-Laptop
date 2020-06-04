using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.ClassesCore;

namespace TrainingProject
{
    public class Ex04_Arrays
    {

        public static void ArrayDemo()
        {

            // Object[] ArrayOfObjects = new Object[] { 1, "3" }; //can store diffrent object types
            
            

            string[] name = new string[3];
            name[0] = "Zeeshan"; // this is one way
            name[1] = "Shezad";
            name[2] = "Neaz";
            Console.WriteLine("Second name is " + name[1]);

            string[] weekdays = new string[] { "MON", "TUE", "WED", "THU", "FRI" }; // this is second way

           
            Console.WriteLine("2nd week day is " + weekdays[1]);

            // two dimensional array
            int[,] empid = new int[,] { { 10, 20, 30 }, { 40, 50, 60 } };

            Console.WriteLine(empid[1, 1]);

            // functions
            Console.WriteLine("length of week days " + weekdays.Length);

            foreach (var chingchoo in empid)
            {
                Console.WriteLine(chingchoo);
            }
            //traditional
            for (int i = 0; i < weekdays.Length; i++)
            {
                Console.WriteLine("traditional: " + weekdays[i]);
            }


            // iterating a 2d array traditional
            for (int k = 0; k < empid.GetLength(0); k++)
            {
                for (int l = 0; l < empid.GetLength(1); l++) { 
                    
                Console.WriteLine("form nested for :"+empid[k, l]);
                }
            }
        }

        public static void ListDemo()
        {

            int num1 = 10;
            int num2 = 20;
            //int ...
            
            List<int> numberList = new List<int>() { 10, 20, 30, 40 };
            numberList.Add(50);
            numberList.Remove(20);
           
           
            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
