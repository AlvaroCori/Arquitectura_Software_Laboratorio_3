using System;

namespace ChocolateAbstractFactory.Classes
{
    public interface IGUIFactory
    {
        IChocolateBar MakeChocolateBar();
        IChocolateChip MakeChocolateChip();
    }
}
