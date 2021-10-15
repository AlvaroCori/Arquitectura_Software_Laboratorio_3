using System;

namespace ChocolateAbstractFactory.Classes
{
    public class TheKingChocolateChip:Chocolate,IChocolateChip
    {
        public TheKingChocolateChip(int measure):base(measure)
        {

        }
        public string GetInformationQuantity()
        {
            return $"Los bombones de chocolates The King vienen en cajas de {_measure} unidades.";
        }
    }
}
