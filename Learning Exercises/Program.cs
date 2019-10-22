using System;

namespace Learning_Exercises
{
    class Program
    {
        private static void RunExerciseOne()
        {
            Console.WriteLine("You successfully ran exercise one!");
        }
        
        private static void RunExerciseTwo()
        {
            Console.WriteLine("You successfully ran exercise two!");
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            // Call your next assignment method here!
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine(" Hit any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tha is not a valid assignment number!");
                    Console.ResetColor();
                }
            }
        }
    }
}
