using System;
using Xunit;
using ChocolateAbstractFactory.Classes;
namespace ChocolateAbstractFactory.UnitTest
{
    public class WonkaChocolateFactoryTest
    {
        [Fact]
        public void TestFactory1()
        {
            WonkaChocolateFactory wonka = new WonkaChocolateFactory();
            IChocolateBar bar = wonka.MakeChocolateBar();
            string expected = "Las barras de chocolate Wonka pesan 500 gr.";
            Assert.Equal(bar.GetInformationWeight(),expected);
        }
        [Fact]
        public void TestFactory2()
        {
            WonkaChocolateFactory wonka = new WonkaChocolateFactory();
            IChocolateChip chips = wonka.MakeChocolateChip();
            string expected = "Los bombones de chocolates Wonka vienen en cajas de 70 unidades.";
            Assert.Equal(chips.GetInformationQuantity(),expected);
        }
    }
}
