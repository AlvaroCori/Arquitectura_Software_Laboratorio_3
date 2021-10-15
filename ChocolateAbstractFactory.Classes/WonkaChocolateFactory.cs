using System;

namespace ChocolateAbstractFactory.Classes
{
    public class WonkaChocolateFactory: IGUIFactory
    {
        public WonkaChocolateFactory()
        {
        }
        public IChocolateBar MakeChocolateBar()
        {
            return new WonkaChocolateBar(500);
        }
        public IChocolateChip MakeChocolateChip()
        {
            return new WonkaChocolateChip(70);
        }
    }
}
