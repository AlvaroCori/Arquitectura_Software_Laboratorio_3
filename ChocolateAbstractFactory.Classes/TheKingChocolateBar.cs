using System;

namespace ChocolateAbstractFactory.Classes
{
    public class TheKingChocolateBar:Chocolate,IChocolateBar
    {
        public TheKingChocolateBar(int measure):base(measure)
        {

        }
        public string GetInformationWeight()
        {
            return $"Las barras de chocolate The King pesan {_measure} gr.";
        }
    }
}
