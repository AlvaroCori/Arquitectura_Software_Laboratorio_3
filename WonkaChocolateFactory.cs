using System;

namespace Arquitectura_Software_Laboratorio_3
{
    public class WonkaChocolateFactory: IGUIFactory
    {
        public IChocolateBar MakeChocolateBar()
        {
            return new TheKingChocolateBar();
        }
        public IChocolateChip MakeChocolateChip()
        {
            return new TheKingChocolateChip();
        }
    }
}
