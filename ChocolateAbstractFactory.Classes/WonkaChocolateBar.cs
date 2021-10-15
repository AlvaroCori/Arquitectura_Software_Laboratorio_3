using System;

namespace ChocolateAbstractFactory.Classes
{
    public class WonkaChocolateBar:Chocolate,IChocolateBar
    {
        public WonkaChocolateBar(int measure):base(measure)
        {

        }
        public string GetInformationWeight()
        {
            return $"Las barras de chocolate Wonka pesan {_measure} gr.";
        }
    }
}
