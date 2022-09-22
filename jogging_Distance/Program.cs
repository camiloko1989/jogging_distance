using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace jogging_Distance
{
    internal class Program
    {
        public static double CalculateSteps(string unit)
        {
            double inputValue = 0;
            WriteLine("Input the steps run in " + unit + " minute");
            inputValue = double.Parse(ReadLine());
            return inputValue;
        }

        public static void CalculateTime(ref int hour, ref int min) //With the reference, I can "return" 2 values for min and hour
        {
            string inputValue;
            WriteLine("Input the hours that you run: ");
            inputValue = ReadLine();
            hour = int.Parse(inputValue);
            WriteLine("Input the mins that you run: ");
            min = int.Parse(ReadLine());

        }

        public static double AverageSteps(double lastSteps, double firstSteps)
        {
            return (lastSteps + firstSteps) / 2.0;
        }


        static void Main(string[] args)
        {
            double stepsFirstMin = 0;
            double stepsLastMin = 0;
            int hoursRun = 0;
            int minsRun = 0;
            double averageSteps = 0;
            int hourInMin = 0;
            int totalTimeRun = 0;
            double FOOTSINSTEP = 2.5;
            double FOOTINMILES = 5280;
            double stepsRun = 0;
            double footsRun = 0;
            double milesRun = 0;

            //1. Ask steps in first minute
            //2. Ask steps in last minute
            stepsFirstMin = CalculateSteps("first");
            stepsLastMin = CalculateSteps("last");

            //3. Ask hours and mins running
            CalculateTime(ref hoursRun, ref minsRun);

            //4. Calculate average steps per minute
            averageSteps = AverageSteps(stepsLastMin, stepsFirstMin);

            //5. Calculate total steps in time run
            hourInMin = hoursRun * 60;
            totalTimeRun = hourInMin + minsRun;

            //7. Calculate distance run in miles
            stepsRun = totalTimeRun * averageSteps;
            footsRun = stepsRun * FOOTSINSTEP;
            milesRun = footsRun / FOOTINMILES;

            WriteLine("You run " + stepsFirstMin + " steps in the first minute");
            WriteLine("You run " + stepsLastMin + " steps in the last minute");
            WriteLine("You run " + hoursRun + " hours, and " + minsRun + " minutes");
            WriteLine("In average you run " + averageSteps + " steps per minute");
            WriteLine("The total mins that you run were: " + totalTimeRun);
            WriteLine("In total you run: " + milesRun + " miles");
            ReadKey();

            
            
            
           
            //8. Show results
        }
    }
}
