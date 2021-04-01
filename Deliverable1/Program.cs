using System;

namespace Deliverable1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello...");

            void StartProgram()
            {
                double realValue = 1;
                //user input

                Console.WriteLine("Please input your unit of measurement.");
                string userUnit = Console.ReadLine();
                Console.WriteLine("Great! now enter your value measured.");
                string userValue = Console.ReadLine();
                double.TryParse(userValue, out realValue);
      

                    //conditional

                      if (userUnit == "inch")
                    {
                        realValue *= 3.5;
                        Console.WriteLine("Conversion...");
                        Console.WriteLine(realValue + " fidget spinners");
                    }
                      else
                    {
                        realValue *= 5;
                        Console.WriteLine("Conversion...");
                        Console.WriteLine(realValue + " memes");

                    }

                    //pseudo-loop
                Console.WriteLine("Would you like to do another conversion? (yes|no)");
                string userAnswer = Console.ReadLine();

                    if (userAnswer == "yes")
                    {
                        StartProgram();
                    }
                    else
                    {
                        Console.WriteLine("Goodbye...");

                    }

            }
            StartProgram();

            
            


        }
    }
}
