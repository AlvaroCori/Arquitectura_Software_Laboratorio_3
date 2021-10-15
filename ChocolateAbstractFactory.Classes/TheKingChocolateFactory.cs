using System;

namespace ChocolateAbstractFactory.Classes
{
    public class TheKingChocolateFactory: IGUIFactory
    {
        public TheKingChocolateFactory()
        {
        }
        public IChocolateBar MakeChocolateBar()
        {
            return new TheKingChocolateBar(400);
        }
        public IChocolateChip MakeChocolateChip()
        {
            return new TheKingChocolateChip(100);
        }
    }
}
