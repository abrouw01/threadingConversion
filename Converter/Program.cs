//Program:      Unit Conversion Class
//Programmer:   Alex Brouwer
//Date:         October 12, 2016
//Description:  Program performs six unit conversions and outputs 3 of them using formatted printing
//              Program also uses multithreading

using System;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double number;
            bool flag = false;

            //change the color because why not :)
            Console.ForegroundColor = ConsoleColor.Green;
       
            //notify user of purpose
            Console.WriteLine("This program will out put various conversions on inches using multiple threads.");
            
            //error check the input
            do
            {
                try
                {
                    Console.WriteLine("Please enter a number of inches. You might want to input a larger number since we will" +
                                       " be converting to much higher units");

                    input = Console.ReadLine();

                    number = Double.Parse(input);
                    flag = true;               //flag is set when input passes both tests

                    Console.Clear();
                    Console.WriteLine("Input accepted. Program will now make conversions using 6 seperate threads.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: Invalid format");
                    number = 0;
                }
            } while (!flag);

            //create coverter object
            convertMe convert = new convertMe(number);

            Console.ReadLine();
        }//end main
    }//end class
}//end namespace
