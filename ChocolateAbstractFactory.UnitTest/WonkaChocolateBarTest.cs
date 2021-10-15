using System;
using Xunit;
using ChocolateAbstractFactory.Classes;
namespace ChocolateAbstractFactory.UnitTest
{
    public class WonkaChocolateBarTest
    {
        [Fact]
        public void TestBar1()
        {
            WonkaChocolateBar bar = new WonkaChocolateBar(500);
            string expected = "Las barras de chocolate Wonka pesan 500 gr.";
            Assert.Equal(bar.GetInformationWeight(),expected);
        }
    }
}
