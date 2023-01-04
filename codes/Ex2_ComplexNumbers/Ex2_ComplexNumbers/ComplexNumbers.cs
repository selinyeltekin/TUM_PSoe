using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_ComplexNumbers
{
    internal class ComplexNumbers
    {
        public double Imaginary { get; set; }   //we are using get and set because we want the class to accepth both real and imaginery
        public double Real { get; set; }

        //constructer defining objects
        public ComplexNumbers(double imaginary, double real)
        {
            this.Imaginary = imaginary;
            this.Real = real;
        }

        //Creating method
        public double GetNorm()
        {
            return Math.Sqrt(Math.Pow(Imaginary, 2) + Math.Pow(Real, 2));
        }

        //Static Methods
        public static ComplexNumbers CreateComplexValue(double real, double imaginary)
        {
            return new ComplexNumbers(real, imaginary);
        }

        public static bool TryParseComplex(string userInput, out ComplexNumbers complexUSerInput) //getting an input from the user and giving out it as real and imaginary values 
        {
            double real = 0;
            double imaginary = 0;

            bool isValid = ComplexNumbers.IsValidComplex(userInput, out real, out imaginary); //getting real and imaginary values by passing them as reference 

            complexUSerInput = new ComplexNumbers(real, imaginary);

            return isValid;
        }

        private static bool IsValidComplex(string userInput, out double real, out double imaginary)
        {
            bool validReal = false, validImaginary = false;

            real = 0;
            imaginary = 0;

            string cleanedUserInput = userInput.Replace(" ", "");   //cleaning whitespaces from the input string

            int operatorIndex = ComplexNumbers.IndexOfOperator(cleanedUserInput);

            if (operatorIndex != -1)    //checks if operator '-' or '+' is found
            {
                //if found try parsing both on real and imaginary parts

                string realAsString = cleanedUserInput.Substring(0, operatorIndex);
                string imaginaryAsString = cleanedUserInput.Substring(operatorIndex + 1, cleanedUserInput.Length - operatorIndex - 2);

                validReal = double.TryParse(realAsString, out real);
                validImaginary = double.TryParse(imaginaryAsString, out imaginary);
            }
            else
            {
                int iIndex = IndexOfI(cleanedUserInput);

                if (iIndex == -1)    //checks if 'i' or 'I' is found
                {
                    //if 'i' is not found, input could be real so try parsing only real part
                    string realAsString = cleanedUserInput;
                    validReal = double.TryParse(realAsString, out real);
                    validImaginary = true;
                }
                else   //if found, try parsing as imaginary
                {
                    string imaginaryAsString = cleanedUserInput.Substring(0, cleanedUserInput.Length - iIndex);
                }
            }
            return validReal && validImaginary;
        }

        private static int IndexOfOperator(string userInput)
        {
            int index = userInput.IndexOf('+');

            if (index == -1)  //if '+' not found, seaarch for '-'
            {
                index = userInput.IndexOf('-');
            }
            return index;
        }

        private static int IndexOfI(string userInput)
        {
            int index = userInput.IndexOf('i');

            if (index == -1)  //if 'i' not found, search for 'I'
            {
                index = userInput.IndexOf('I');
            }
            return index;
        }

    }

    }

