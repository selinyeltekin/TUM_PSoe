using System;

namespace First_Class_PSE
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Enter a number: ");
            var userInput = Console.ReadLine();
            int userInputInt = Convert.ToInt32(userInput);

            Console.WriteLine("Your input is: " + userInputInt);

            if (userInputInt % 2 == 0)
            {
                Console.WriteLine("Your input is an even number.");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Your input is an odd number.");
                Console.Read();    */





            /*

            //------------Homework Exercises---Tax Computation
            //Use arrays to store the tax percentages and salary limits,

            //! steps: 
            //! -> we create 3 arrays to store out inputs (percentages/salaries/limits)
            //! -> create an empty array to store our result
            //! -> loop through the salaries: 
            //!     -> check which tax bracket to use (if statement)
            //!     -> calculate the income tax and store it in the empty array
            //! -> loop through the result "incomeTax" and print each array entry to the console

            //TODO Use a foreach loop instead of a for loop to print the income tax

            //inputs and creating arrays
            double[] taxBracketsPercentage = {
                0 , 0.25, 0.42, 0.45
            };
            double[] salaryLimits =
            {
                10e3 , 60e3 , 280e3
            };
            int[] salaries =
            {
                20450 , 5340 , 88500 , 1030 , 539400
            };

            int numberOfSalaries = salaries.Length;

            double[] incomeTax = new double[numberOfSalaries];  //creating new array thats equal to`salaries`.

            for (int i = 0; i < numberOfSalaries; i++)
            {
                //check salary against all salaryLimits
                if (salaries[i] < salaryLimits[0])
                {
                    incomeTax[i] = 0.0;
                }
                else if (salaries[i] < 60e3 && salaries[i] >= 10e3)
                {
                    incomeTax[i] = (salaries[i] - 10e3) * taxBracketsPercentage[1];
                }
                else if (salaries[i] < 280e3 && salaries[i] >= 60e3)
                    incomeTax[i] = (salaries[i] - 60e3) * taxBracketsPercentage[2] + 50e3 + taxBracketsPercentage[1];
                else
                {
                    incomeTax[i] = (salaries[i] - 280e3) * taxBracketsPercentage[3] + 220e3 * taxBracketsPercentage[2] + 50e3 * taxBracketsPercentage[1];
                }
            }

            for (var i = 0; i < numberOfSalaries; i++)
            {
                System.Console.WriteLine($"Income Tax for employee {i}: \t {incomeTax[i]}");
            }

            Console.ReadLine();

            */




        }
    }
}
