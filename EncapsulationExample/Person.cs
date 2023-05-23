using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    public class Person
    {
        public double _wallet;
        public string Name { get; set; } = "Bob";
        public int Age { get; set; }

        public void AddMoney(double moneyToAdd)
        {
            _wallet += moneyToAdd;
        }

        public double CheckWallet()
        {
            return _wallet;
        }
    }
}
