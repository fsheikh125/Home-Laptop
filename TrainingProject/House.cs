using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    class House
    {

        public void OpenDoor()
        {
            Console.WriteLine("open the door ...");
            Details();
        }

        public void CloseDoor (string roomName)
        {

            Console.WriteLine("clsoing door of "+roomName);
        }

        public int getNumberOfBedrooms()
        {

            CloseDoor("living room");
            Console.WriteLine("counting bed rooms ....");
            //int x = 3;
            return 2;
       }


        public  int calcuateHouseRent( int bedrooms)
        {
            Console.WriteLine(  "calculating house price ...");
            int cost = bedrooms * 500;
            return cost;
        }



          void Details()
        {   
            Console.WriteLine("house is in london road");
        }

        public static bool CarParking (int noOfBedRooms)
        {
            if(noOfBedRooms>2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
