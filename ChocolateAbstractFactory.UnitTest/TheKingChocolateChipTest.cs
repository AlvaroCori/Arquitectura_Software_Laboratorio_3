using System;
using Xunit;
using ChocolateAbstractFactory.Classes;
namespace ChocolateAbstractFactory.UnitTest
{
    public class TheKingChocolateChipTest
    {
        [Fact]
        public void TestChip1()
        {
            TheKingChocolateChip chips = new TheKingChocolateChip(100);
            string expected = "Los bombones de chocolates The King vienen en cajas de 100 unidades.";
            Assert.Equal(chips.GetInformationQuantity(),expected);
        }
    }
}
