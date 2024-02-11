namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input for billAmount
            Console.WriteLine("Enter total bill amount");
            long.TryParse(Console.ReadLine(), out long billAmount);
            long result = CalculateDiscount(billAmount);
            Console.Write($"final calculated discount is : {result}");
            Console.ReadKey();
        }
        public static int CalculateDiscount(long billAmount)
        {
            // Write your code here example 136, 86, 357, 12294
            int discount = 0;
            long billAmt = billAmount;
            while (billAmt > 0)
            {
                var digit = billAmt % 10;
                if (digit % 2 != 0)
                {
                    discount += (int)digit;
                }
                billAmt /= 10;
            }
            return discount;
        }
    }
}
