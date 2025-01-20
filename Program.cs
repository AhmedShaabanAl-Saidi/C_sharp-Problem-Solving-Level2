namespace C_sharp_Problem_Solving_Level2
{
    internal class Program
    {
        #region StoreSellProducts Function
        public static void StoreSellProducts(int numOfBooks = 0, int numOfElectronics = 0, int numOfClothing = 0)
        {
            Console.WriteLine("Welcome in Store Sell Product App :");

            decimal booksPrice = 24.99m;
            decimal electronicsPrice = 149.95m;
            decimal clothingPrice = 39.50m;

            Console.WriteLine($"Total price of : \"{numOfBooks} Books , {numOfElectronics} Electronics , {numOfClothing} Clothing\" = {(numOfBooks * booksPrice) + (numOfElectronics * electronicsPrice) + (numOfClothing * clothingPrice)}$");
        }
        #endregion

        #region WeekendCustomers Function
        public static void WeekendCustomers(int storeServesNums)
        {
            Console.WriteLine("Welcome in Weekend Customers App :");

            Console.WriteLine($"Store Serves in Weekend More 10% Customers = {storeServesNums + (storeServesNums * 0.10)}");
        }
        #endregion

        #region BuyOneGetHalf Function
        public static void BuyOneGetHalf(int numOfPurchase)
        {
            Console.WriteLine("Welcome in Buy One Get Half App :");

            decimal tshirtPrice = 32m;

            decimal boundelPrice = tshirtPrice + (tshirtPrice * 0.5m);
            int boundelCount = numOfPurchase / 2;

            if (numOfPurchase % 2 == 0)
                Console.WriteLine($"Price of {numOfPurchase} Tshirts = {boundelPrice * boundelCount}$");
            else
                Console.WriteLine($"Price of {numOfPurchase} Tshirts = {(boundelPrice * boundelCount) + tshirtPrice}$");
        }
        #endregion

        #region IsPrime Function
        public static bool isPrime(int num)
        {
            if (num == 1 || num == 0)
            {
                return false;
            }
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Convert Binary To Decimal
        #region Power Function
        public static double Power(double baseValue, double powerValue)
        {
            if (powerValue == 0)
                return 1;

            double result = 1;

            for (int i = 1; i <= powerValue; i++)
            {
                result *= baseValue;
            }

            return result;
        }
        #endregion

        public static double ConvertBinaryToDecimal(string binary)
        {
            double descimalValue = 0;
            int baseBinary = 0;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    descimalValue += Power(2, baseBinary);
                }
                baseBinary++;
            }
            return descimalValue;
        }
        #endregion

        #region Fibonacci Series
        public static void FibonacciSeries(int stopNumber)
        {
            Console.WriteLine("Fibonacci Series :");
            Console.WriteLine("**************************");

            int fristNumber = 0;
            int secondNumber = 1;
            int nextNumber = 0;

            Console.Write(fristNumber + " ");
            Console.Write(secondNumber + " ");

            for (int i = 2; i < stopNumber; i++)
            {
                nextNumber = fristNumber + secondNumber;

                fristNumber = secondNumber;
                secondNumber = nextNumber;

                Console.Write(nextNumber + " ");
            }
        }
        #endregion

        static void Main(string[] args)
        {
            //StoreSellProducts(1,1,1);

            //WeekendCustomers(120);

            //BuyOneGetHalf(5);

            //Console.WriteLine(isPrime(27) ? "Prime" : "Not Prime");

            //Console.WriteLine( ConvertBinaryToDecimal("111"));

            FibonacciSeries(10);
        }
    }
}