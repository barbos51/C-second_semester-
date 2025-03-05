using System.Text;

namespace task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Product apple = new Product("Яблуко", 5, 100);
            Console.WriteLine(apple.GetInfo());

            apple.Sell(20);
            Console.WriteLine(apple.GetInfo());


            apple.Restock(70);
            Console.WriteLine(apple.GetInfo());


            apple.Price = 12; // Зміна ціни товару
            Console.WriteLine(apple.GetInfo());

            apple.Name = "Зелене яблуко"; // Перейменування товару
            Console.WriteLine(apple.GetInfo());

            apple.Price=-12;
            
        }
    }
}
