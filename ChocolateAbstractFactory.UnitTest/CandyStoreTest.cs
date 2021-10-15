using System;
using Xunit;
using ChocolateAbstractFactory.Classes;
namespace ChocolateAbstractFactory.UnitTest
{
    public class CandyStoreTest
    {
        [Fact]
        public void TestStore1()
        {
            WonkaChocolateFactory wonka = new WonkaChocolateFactory();
            CandyStore store = new CandyStore("Paulette",wonka);
            store.RequestChocolate();
            string expected = "La tienda de Paulette ofrece:\nLos bombones de chocolates Wonka vienen en cajas de 70 unidades.";
            Assert.Equal(store.GetInfoChocolateChip(),expected);
        }
        [Fact]
        public void TestStore2()
        {
            WonkaChocolateFactory wonka = new WonkaChocolateFactory();
            CandyStore store = new CandyStore("Paulette",wonka);
            store.RequestChocolate();
            string expected = "La tienda de Paulette ofrece:\nLas barras de chocolate Wonka pesan 500 gr.";
            Assert.Equal(store.GetInfoChocolateBar(),expected);
        }
        [Fact]
        public void TestStore3()
        {
            TheKingChocolateFactory theKing = new TheKingChocolateFactory();
            CandyStore store = new CandyStore("Lucia",theKing);
            store.RequestChocolate();
            string expected = "La tienda de Lucia ofrece:\nLos bombones de chocolates The King vienen en cajas de 100 unidades.";
            Assert.Equal(store.GetInfoChocolateChip(),expected);
        }
        [Fact]
        public void TestStore4()
        {
            TheKingChocolateFactory theKing = new TheKingChocolateFactory();
            CandyStore store = new CandyStore("Lucia",theKing);
            store.RequestChocolate();
            string expected = "La tienda de Lucia ofrece:\nLas barras de chocolate The King pesan 400 gr.";
            Assert.Equal(store.GetInfoChocolateBar(),expected);
        }
    }
}
