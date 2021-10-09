using System;

namespace Arquitectura_Software_Laboratorio_3
{
    public interface IGUIFactory
    {
        IChocolateBar MakeChocolateBar();
        IChocolateChip MakeChocolateChip();
    }
}
