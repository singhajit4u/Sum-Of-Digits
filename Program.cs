namespace Sum_Of_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number for finding its sum:");
            int number =Convert.ToInt32(Console.ReadLine());
            int sum, remainder;
            sum = 0;
            while (number>0)
            {
                remainder = number % 10;
                sum=sum+remainder;  
                number=number/10;
            }

            Console.Write("The sum is:"+ sum);
        }
    }
}