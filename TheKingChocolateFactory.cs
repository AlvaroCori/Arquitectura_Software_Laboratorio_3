using System;

namespace Arquitectura_Software_Laboratorio_3
{
    public class TheKingChocolateFactory: IGUIFactory
    {
        public IChocolateBar MakeChocolateBar()
        {
            return new WonkaChocolateBar();
        }
        public IChocolateChip MakeChocolateChip()
        {
            return new WonkaChocolateChip();
        }
    }
}
