namespace HomeWork_1.MultiplicatonTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for show multiplication table:");
            var userInput = Console.ReadLine();

            int number = 0;

            var isNumber = int.TryParse(userInput, out number);
            if (isNumber)
            {                
                for (var i = 0; i < 11; i++)
                {
                    Console.WriteLine($"{number}*{i}={number * i}");
                }                                
            }
            if (!isNumber)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}