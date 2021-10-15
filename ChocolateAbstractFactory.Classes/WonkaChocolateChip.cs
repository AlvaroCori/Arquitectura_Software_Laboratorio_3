using System;

namespace ChocolateAbstractFactory.Classes
{
    public class WonkaChocolateChip:Chocolate,IChocolateChip
    {
        public WonkaChocolateChip(int measure):base(measure)
        {

        }
        public string GetInformationQuantity()
        {
            return $"Los bombones de chocolates Wonka vienen en cajas de {_measure} unidades.";
        }
    }
}
