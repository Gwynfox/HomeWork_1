namespace HomeWork_1.Days_of_the_week    // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Hello! Plaese enter number of the day of the week (1-7).");
            
            var nomberWeek = Console.ReadLine();
            
            switch (nomberWeek)
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("It's not number of the day of the week!!! Please,try again and enter number 1-7");
                    break;
            }
            
        }
    }
}