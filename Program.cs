using System.IO;

namespace Lab0
{
    internal class Program
    {
        static void Task1()
        {
            // Task 1: Creating variables
            Console.Write("Please enter a low number: ");
            int lowNum = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Please enter a high number (larger than {lowNum}): ");
            int highNum = Convert.ToInt32(Console.ReadLine());

            int diff = highNum - lowNum;

            Console.WriteLine("The difference between the high number and low number is: " + diff);
        }

        static void Task2()
        {
            // Task 2: Looping and Input Validation
            Console.Write("Please enter a positive low number: ");
            int lowNum = Convert.ToInt32(Console.ReadLine());
            while (lowNum < 0)
            {
                Console.WriteLine("Invalid number. Please enter again.");
                Console.Write("Please enter a positive low number: ");
                lowNum = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write($"Please enter a high number (larger than {lowNum}): ");
            int highNum = Convert.ToInt32(Console.ReadLine());

            while (highNum <= lowNum)
            {
                Console.WriteLine("Invalid number. Please enter again.");
                Console.Write($"Please enter a high number (larger than {lowNum}): ");
                highNum = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"The low number is: {lowNum} | The high number is: {highNum}");
        }

        static void Task3()
        {
            // Task 3: Using Arrays and File I/O
            
            // Copy from Task2 validating input
            Console.Write("Please enter a positive low number: ");
            int lowNum = Convert.ToInt32(Console.ReadLine());
            while (lowNum < 0)
            {
                Console.WriteLine("Invalid number. Please enter again.");
                Console.Write("Please enter a positive low number: ");
                lowNum = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write($"Please enter a high number (larger than {lowNum}): ");
            int highNum = Convert.ToInt32(Console.ReadLine());

            while (highNum <= lowNum)
            {
                Console.WriteLine("Invalid number. Please enter again.");
                Console.Write($"Please enter a high number (larger than {lowNum}): ");
                highNum = Convert.ToInt32(Console.ReadLine());
            }

            // Add the numbers between highNum and lowNum in the array;
            int n = highNum - lowNum;
            int[] arr = new int[n-1];
            int number = lowNum+1;
            for(int i = 0; i < n-1; i++)
            {
                arr[i] = number;
                number++;
            }

            // Writing to the numbers.txt file
            // Taken from example documentation: https://learn.microsoft.com/en-us/dotnet/api/system.io.file?view=net-9.0
            using (StreamWriter stream = File.CreateText("numbers.txt"))
            {
                for(int i = n-2; i >= 0; i--)
                {
                    stream.WriteLine(arr[i]);
                    Console.WriteLine(arr[i]);
                }
            }

            Console.WriteLine("Finish writing the numbers between lowNum and highNum");
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
    }
}
