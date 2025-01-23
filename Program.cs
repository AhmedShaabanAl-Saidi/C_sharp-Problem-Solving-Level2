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

        #region Copy Array
        public static int[] CopyArray(int[] array)
        {
            int[] copiedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                copiedArray[i] = array[i];
            }
            return copiedArray;
        }
        #endregion

        #region Copy Half Of Array
        public static int[] CopyHalfOfArray(int[] array)
        {
            int arrayLength = array.Length;
            if (arrayLength % 2 != 0)
            {
                arrayLength++;
            }

            int[] copiedArray = new int[(arrayLength / 2)];
            for (int i = 0; i < (arrayLength / 2); i++)
            {
                copiedArray[i] = array[i];
            }
            return copiedArray;
        }
        #endregion

        #region Copy Half Of Array End To Start
        public static int[] CopyHalfOfArrayEndToStart(int[] array)
        {
            int arrayLength = array.Length;
            int counter = 0;

            if (arrayLength % 2 != 0)
            {
                arrayLength++;
            }

            int[] copiedArray = new int[(arrayLength / 2)];

            for (int i = (array.Length - 1); i >= (array.Length - (arrayLength / 2)); i--)
            {
                copiedArray[counter] = array[i];
                counter++;
            }
            return copiedArray;
        }
        #endregion

        #region Copy From Start
        public static void CopyFromStart(int[] arrayFrom,int[] arrayTo,int lenght,int startPosition = 0)
        {
            for (int i = 0; i < lenght; i++)
            {
                arrayTo[startPosition] = arrayFrom[i];
                startPosition++;
            }
        }
        #endregion

        #region Copy From End
        public static void CopyFromEnd(int[] arrayFrom, int[] arrayTo, int lenght, int startPosition = 0)
        {
            for (int i = arrayFrom.Length -1; i >= arrayFrom.Length - lenght ; i--)
            {
                arrayTo[startPosition] = arrayFrom[i];
                startPosition++;
            }
        }
        #endregion

        #region Merge Two Arrays
        public static int[] MergeTwoArrays(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            //int counter = 0;
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    mergedArray[counter] = array1[i];
            //    counter++;
            //}
            //for (int i = 0; i < array2.Length; i++)
            //{
            //    mergedArray[counter] = array2[i];
            //    counter++;
            //}
            CopyFromStart(array1, mergedArray, array1.Length);
            CopyFromStart(array2, mergedArray, array2.Length, array1.Length);

            return mergedArray;
        }

        public static int[] MergeTwoArrays(int[] array1,int fristLenght, int[] array2 , int secondLenght)
        {
            int[] mergedArray = new int[fristLenght + secondLenght];
           
            CopyFromStart(array1, mergedArray, fristLenght);
            CopyFromStart(array2, mergedArray, secondLenght, fristLenght);

            return mergedArray;
        }

        public static int[] MergeTwoArraysFromEnd(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            
            CopyFromEnd(array1, mergedArray, array1.Length);
            CopyFromEnd(array2, mergedArray, array2.Length, array1.Length);

            return mergedArray;
        }

        public static int[] MergeTwoArraysFromEnd(int[] array1, int fristLenght, int[] array2, int secondLenght)
        {
            int[] mergedArray = new int[fristLenght + secondLenght];

            CopyFromEnd(array1, mergedArray, fristLenght);
            CopyFromEnd(array2, mergedArray, secondLenght, fristLenght);

            return mergedArray;
        }
        #endregion

        #region isFound
        public static bool IsFound(int number , int[] array)
        {
            foreach (int item in array)
            {
                if (item == number)
                    return true;
            }
            return false;
        }
        #endregion

        #region Deference Between Two Arrays
        public static int[] DeferenceBetweenTwoArrays(int[] array1, int[] array2)
        {
            int[] newArray = new int[array1.Length];
            int counter = 0;

            foreach (int item in array1)
            {
                if (!IsFound(item, array2))
                {
                    newArray[counter] = item;
                    counter++;
                }
            }
            return newArray;
        }
        #endregion


        static void Main(string[] args)
        {
            //StoreSellProducts(1,1,1);

            //WeekendCustomers(120);

            //BuyOneGetHalf(5);

            //Console.WriteLine(isPrime(27) ? "Prime" : "Not Prime");

            //Console.WriteLine( ConvertBinaryToDecimal("111"));

            //FibonacciSeries(10);

            //int[] array = { 1, 2, 3, 4, 5 };
            //int[] copiedArray = CopyArray(array);
            //Console.WriteLine(copiedArray[0]);

            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] CopyHalf = CopyHalfOfArrayEndToStart(array);

            //foreach (int number in CopyHalf)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] array1 = { 1, 2, 3, 4, 5 };
            //int[] array2 = { 6, 7, 8, 9, 10 };
            //int[] mergedArray = MergeTwoArrays(array1 ,2, array2,5);
            //foreach (int number in mergedArray)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] array1 = { 1, 2, 3, 4, 5 };
            //int[] array2 = { 6, 7, 8, 9, 10 };
            //int[] mergedArray = MergeTwoArraysFromEnd(array1,2, array2,2);
            //foreach (int number in mergedArray)
            //{
            //    Console.WriteLine(number);
            //}

            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 4 , 5, 7, 8, 9};
            int[] newArray = DeferenceBetweenTwoArrays(array1, array2);
            foreach (int number in newArray)
            {
               Console.WriteLine(number);
            }

        }
    }
}