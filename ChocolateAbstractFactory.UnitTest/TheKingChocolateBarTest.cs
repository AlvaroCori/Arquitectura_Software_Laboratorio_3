using System;
using Xunit;
using ChocolateAbstractFactory.Classes;
namespace ChocolateAbstractFactory.UnitTest
{
    public class TheKingChocolateBarTest
    {
        [Fact]
        public void TestBar1()
        {
            TheKingChocolateBar bar = new TheKingChocolateBar(400);
            string expected = "Las barras de chocolate The King pesan 400 gr.";
            Assert.Equal(bar.GetInformationWeight(),expected);
        }
    }
}
