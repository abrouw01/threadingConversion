using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Converter
{
    //conversion class takes any number of inches. Returns feet, miles, meters, kilometers, centimeters and milimeters.
    //I made some of the constants into a higher unit so I did not have to give them a scientific constant value
    class convertMe
    {
        private const double INCHES_IN_FEET = 0.0833f;
        private const double FEET_IN_MILE = 0.001893f;
        private const double INCHES_IN_METER = 0.0254f;
        private const double MILES_IN_KM = 1.609f;
        private const double INCHES_IN_CM = 2.54f;
        private const double INCHES_IN_MM = 25.4f;
        private double numberOfInches;
        Thread T1;
        Thread T2;
        Thread T3;
        Thread T4;
        Thread T5;
        Thread T6;

        public convertMe(double num)
        {
            //assign variables and assign thread tasks
            numberOfInches = num;
            T1 = new Thread(new ThreadStart(returnFeet));
            T2 = new Thread(new ThreadStart(returnMiles));
            T3 = new Thread(new ThreadStart(returnMeters));
            T4 = new Thread(new ThreadStart(returnKM));
            T5 = new Thread(new ThreadStart(returnCM));
            T6 = new Thread(new ThreadStart(returnMM));
            //run threads
            T1.Start();
            T2.Start();
            T3.Start();
            T4.Start();
            T5.Start();
            T6.Start();


        }
        //returns how many feet are in input
        public void returnFeet()
        {
            Console.WriteLine("T1 start");
            Console.WriteLine("There are {0:F5} feet in {1:F3} inches", (numberOfInches * INCHES_IN_FEET), numberOfInches );
        }
        //returns how many miles are in input
        public void returnMiles()
        {
            Console.WriteLine("T2 start");
            Console.WriteLine("There are {0:F5} miles in {1:F3} inches", (numberOfInches * INCHES_IN_FEET * FEET_IN_MILE), numberOfInches);
        }
        //returns how many meters are in input
        public void returnMeters()
        {
            Console.WriteLine("T3 start");
            Console.WriteLine("There are {0:F5} meters in {1:F3} inches",(numberOfInches * INCHES_IN_METER), numberOfInches);
        }
        //returns how many KM are in input
        public void returnKM()
        {
            Console.WriteLine("T4 start");
            Console.WriteLine("There are {0:F5} KM in {1:F3} inches", (numberOfInches * INCHES_IN_FEET * FEET_IN_MILE * MILES_IN_KM), numberOfInches);
        }
        //returns how many CM are in input
        public void returnCM()
        {
            Console.WriteLine("T5 start");
            Console.WriteLine("There are {0:F5} CM in {1:F3} inches", (numberOfInches * INCHES_IN_CM), numberOfInches);
        }
        //returns how many MM are in input
        public void returnMM()
        {
            Console.WriteLine("T6 start");
            Console.WriteLine("There are {0:F5} MM in {1:F3} inches", (numberOfInches * INCHES_IN_MM), numberOfInches);
        }
    }
}
