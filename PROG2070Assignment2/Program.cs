using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
    class Program
    {
        public static bool validateInput(string validationString)
        {
            bool valid = true;

            try
            {
                int.Parse(validationString);
            }
            catch (Exception)
            {
                valid = false;
                Console.WriteLine("Invalid Input");
            }


            return valid;
        }
        static void Main(string[] args)
        {
            int menuSelection = 0;
            int firstDimension = 0;
            int secondDimension = 0;
            int thirdDimension = 0;
            string validationString = "";
            bool validate = true;
            do
            {
                Console.WriteLine("1. Enter Triangle Dimensions");
                Console.WriteLine("2. Exit");
                validationString = Console.ReadLine();
                if (validateInput(validationString))
                {
                    menuSelection = int.Parse(validationString);
                }

                if (menuSelection == 1)
                {
                    validate = true;
                    do
                    {
                        Console.Write("Enter 1st dimension: ");
                        validationString = Console.ReadLine();
                        if (validateInput(validationString))
                        {
                            firstDimension = int.Parse(validationString);
                        }
                        else
                        {
                            validate = false;
                            continue;
                        }

                        Console.Write("Enter 2nd dimension: ");
                        validationString = Console.ReadLine();
                        if (validateInput(validationString))
                        {
                            secondDimension = int.Parse(validationString);
                        }
                        else
                        {
                            validate = false;
                            continue;
                        }

                        Console.Write("Enter 3rd dimension: ");
                        validationString = Console.ReadLine();
                        if (validateInput(validationString))
                        {
                            thirdDimension = int.Parse(validationString);
                        }
                        else
                        {
                            validate = false;
                            continue;
                        }
                    } while (validate == false);
                    Console.WriteLine(TriangleSolver.Analyze(firstDimension, secondDimension, thirdDimension));
                }
                else if (menuSelection != 2)
                {
                    Console.WriteLine("Please enter a 1 or 2");
                }
            } while (menuSelection != 2);
        }
    }
}
