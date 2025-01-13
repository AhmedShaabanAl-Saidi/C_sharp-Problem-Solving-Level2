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

        static void Main(string[] args)
        {
            //StoreSellProducts(1,1,1);

            //WeekendCustomers(120);
        }
    }
}
