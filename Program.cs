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

        static void Main(string[] args)
        {
            Task1();
        }
    }
}
