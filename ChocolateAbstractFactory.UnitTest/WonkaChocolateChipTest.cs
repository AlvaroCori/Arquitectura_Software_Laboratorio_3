using System;
using Xunit;
using ChocolateAbstractFactory.Classes;
namespace ChocolateAbstractFactory.UnitTest
{
    public class WonkaChocolateChipTest
    {
        [Fact]
        public void TestChip1()
        {
            WonkaChocolateChip chips = new WonkaChocolateChip(70);
            string expected = "Los bombones de chocolates Wonka vienen en cajas de 70 unidades.";
            Assert.Equal(chips.GetInformationQuantity(),expected);
        }
    }
}
