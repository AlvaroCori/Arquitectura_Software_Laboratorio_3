using System;
using ChocolateAbstractFactory.Classes;
namespace ChocolateAbstractFactory.MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            CandyStore store1 = new CandyStore("Juan",new TheKingChocolateFactory());
            CandyStore store2 = new CandyStore("Jim",new WonkaChocolateFactory());
            
            store1.RequestChocolate();
            store2.RequestChocolate();
            Console.WriteLine("Chocolates comparacion:\n");
            Console.WriteLine(store1.GetInfoChocolateBar());
            Console.WriteLine(store1.GetInfoChocolateChip());
            Console.WriteLine(store2.GetInfoChocolateBar());
            Console.WriteLine(store2.GetInfoChocolateChip());
        }
    }
}
