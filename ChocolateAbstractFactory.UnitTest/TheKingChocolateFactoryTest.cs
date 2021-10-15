using System;
using Xunit;
using ChocolateAbstractFactory.Classes;
namespace ChocolateAbstractFactory.UnitTest
{
    public class TheKingChocolateFactoryTest
    {
        [Fact]
        public void TestFactory1()
        {
            TheKingChocolateFactory theKing = new TheKingChocolateFactory();
            IChocolateBar bar = theKing.MakeChocolateBar();
            string expected = "Las barras de chocolate The King pesan 400 gr.";
            Assert.Equal(bar.GetInformationWeight(),expected);
        }
        [Fact]
        public void TestFactory2()
        {
            TheKingChocolateFactory theKing = new TheKingChocolateFactory();
            IChocolateChip chips = theKing.MakeChocolateChip();
            string expected = "Los bombones de chocolates The King vienen en cajas de 100 unidades.";
            Assert.Equal(chips.GetInformationQuantity(),expected);
        }
    }
}
