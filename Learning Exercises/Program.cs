using System;

namespace Learning_Exercises
{
    class Program
    {
        private static void RunExerciseOne()
        {
            string firstName = "Peter";
            string lastName = "Pan";

            Console.WriteLine("Hello " + firstName + " " + lastName + "!  I’m glad to inform you that you are the test subject of my very first assignment");
            Console.WriteLine("You successfully ran exercise one!");
        }

        private static void RunExerciseTwo()
        {
            var dateToday = DateTime.Now;
            var dateYesterday = DateTime.Now.AddDays(-1);
            var dateTomorrow = DateTime.Now.AddDays(+1) + Environment.NewLine;

            Console.WriteLine("Todays date is " + dateToday.Day + "/" + dateYesterday.Month + "/" + dateYesterday.Year);
            Console.WriteLine("Tomorrows date is " + dateYesterday.Day + "/" + dateYesterday.Month + "/" + dateYesterday.Year);
            Console.WriteLine("Yesterdays date was " + dateYesterday.Day + "/" + dateYesterday.Month + "/" + dateYesterday.Year);
            Console.WriteLine("You successfully ran exercise two!");
        }

        private static void RunExerciseThree()
        {
            Console.Write("Enter your first name followed by enter: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name followed by enter: ");
            string lastName = Console.ReadLine();
            Console.WriteLine(firstName + " " + lastName);

        }

        private static void RunExerciseFour()
        {
            String str = "The quick fox Jumped Over the DOG";
                    //“The brown fox jumped over the lazy dog”,
            // code here 
            str = str.Substring(0, 3);
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

    
            //CTRL + K + C - avkommentera CTRL + K + U
            //String part = "if you're doing your, \tr "; 
            //part = part + " best, \tyou won't have any"; 
            //String quote = part + " time to worry about failure."; 
            //Console.WriteLine(quote);

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
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
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
