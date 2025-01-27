using System.IO;

namespace Lab0
{
    internal class Program
    {
        static bool IsPrime(double n)
        {
            if (n < 2) return false;
            for(double i = 2; i*i <= n; i++)
                if(n % i == 0) return false;

            return true;
        }

        static double GetUserInput()
        {
            double number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        static bool ValidateUserInput(double lowNum, double highNum)
        {
            if(lowNum < highNum) return false;
            if (lowNum < 0 || highNum < 0) return false;

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter a positive low number: ");
            double lowNum = GetUserInput();

            Console.Write($"Please enter a high number (larger than {lowNum}): ");
            double highNum = GetUserInput();

            while (!ValidateUserInput(highNum, lowNum))
            {
                Console.WriteLine("Invalid low number and high number. Please enter again.");
                Console.Write("Please enter a positive low number: ");
                lowNum = GetUserInput();
                Console.Write($"Please enter a high number (larger than {lowNum}): ");
                highNum = GetUserInput();
            }

            // Add the numbers between highNum and lowNum in the array;
            int n = (int)highNum - (int)lowNum;
            List<double> numList = new List<double>();
            int number = (int)lowNum + 1;
            for (int i = 0; i < n - 1; i++)
            {
                numList.Add(number);
                number++;
            }

            // Writing to the numbers.txt file
            // Taken from example documentation: https://learn.microsoft.com/en-us/dotnet/api/system.io.file?view=net-9.0
            using (StreamWriter stream = File.CreateText("numbers.txt"))
            {
                // Write/print out the numbers in the list except the lowNum and highNum
                // Cause we are only printing/writing out between
                for (int i = n - 2; i >= 0; i--)
                {
                    stream.WriteLine(numList[i]);
                    Console.WriteLine(numList[i]);
                }
            }

            Console.WriteLine("Finish writing the numbers between lowNum and highNum");

            // Read the numbers in the file and adding it into the variable
            double sum = 0;
            using (StreamReader stream = File.OpenText("numbers.txt"))
            {
                while(!stream.EndOfStream)
                {
                    double num = Convert.ToDouble(stream.ReadLine());
                    sum += num;
                }
            }

            Console.WriteLine("The sum of the numbers in the \"numbers.txt\" file is: " + sum);

            // Go through the numbers between highNum and lowNum and check for prime numbers
            Console.WriteLine($"The prime numbers between {lowNum} and {highNum} is: ");

            for(double i = lowNum+1; i < highNum; i++)
            {
                if (IsPrime(i))
                    Console.WriteLine($"{i} is a prime number");
            }
        }
    }
}
