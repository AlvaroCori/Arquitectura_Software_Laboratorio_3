using System;

namespace Arquitectura_Software_Laboratorio_3
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
            Console.WriteLine(store1.ViewInfoChocolateBar());
            Console.WriteLine(store1.ViewInfoChocolateChip());
            Console.WriteLine(store2.ViewInfoChocolateBar());
            Console.WriteLine(store2.ViewInfoChocolateChip());
        }
    }
}
