using System.Net.NetworkInformation;

namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
            return sum;
        }

        public static double Add(double a, double b) { 
            double sum = a + b;
            Console.WriteLine(sum);
            return sum;
        }

        public static string Add(int a, int b, bool truth) {
            int sum = a + b;
            string currency = "";
            string dollarAmt = "";
            if (truth)
            {
                currency = sum > 1 ? " dollars" : " dollar";
                dollarAmt = sum + currency;
                Console.WriteLine(dollarAmt);
            }
            return dollarAmt;
        }

        static void Main(string[] args)
        {
            Add(1.12, 2.11);
        }
    }
}
