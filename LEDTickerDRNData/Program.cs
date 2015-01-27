using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEDTickerDRNData
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //User input to the console application
                //Color and message inputs
                Console.WriteLine("Enter input:"); //Prompt
                Console.WriteLine("Type 'exit' to exit program");
                string line = Console.ReadLine(); //Input
                Console.WriteLine("Enter a text color");
                string color = Console.ReadLine(); //ColorInput
                Type type = typeof(ConsoleColor);
                Console.ForegroundColor = ConsoleColor.White;


                

                var Prohibited = new List<string> { "bubble gum", "water gun", "butterscotch", "cupcake" };

                bool contains = Prohibited.Contains(line, StringComparer.OrdinalIgnoreCase);

                if (contains)
                {                    
                    Console.Write("Invalid Input Please Try Again");
                }

                if (line.Length > 140)
                {
                    Console.Write("Invalid Input Please Have Less Than 140 Characters");
                }

                if (line == "exit")
                {
                    Environment.Exit(0);
                }

                Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, color);
                Console.Write(" You Typed "); //Report output
                Console.Write(line.Length);
                Console.WriteLine(" character(s)");
                
                
            }

           


        }


    }


}
