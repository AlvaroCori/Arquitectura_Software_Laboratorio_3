using System;

namespace ChocolateAbstractFactory.Classes
{
    public class CandyStore
    {
        private string _name;
        private IGUIFactory _factory;
        private IChocolateBar _chocolateBar;
        private IChocolateChip _chocolateChip;
        public CandyStore(string name, IGUIFactory factory)
        {
            _name = name;
            _factory = factory;
        }
        public void RequestChocolate()
        {
            _chocolateBar = _factory.MakeChocolateBar();
            _chocolateChip = _factory.MakeChocolateChip();
        }

        public string GetInfoChocolateBar()
        {
            return $"La tienda de {_name} ofrece:\n"+_chocolateBar.GetInformationWeight();
        }
        public string GetInfoChocolateChip()
        {
            return $"La tienda de {_name} ofrece:\n"+_chocolateChip.GetInformationQuantity();
        }
    }
}
