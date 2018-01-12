using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Models
{
    public class Money
    {
        private double _valueToSell;

        public double valueToSell
        {
            get { return _valueToSell; }
            set { _valueToSell = value; }
        }

        private double _valueToBuy;

        public double valueToBuy
        {
            get { return _valueToBuy; }
            set { _valueToBuy = value; }
        }


        private string _lastUpdate;

        public string lastUpdate
        {
            get { return _lastUpdate; }
            set { _lastUpdate = value; }
        }


        public Money() { }

        public Money(double valueToSell, double valueToBuy, string lastUpdate)
        {
            this.valueToSell = valueToSell;
            this.valueToBuy = valueToBuy;
            this.lastUpdate = lastUpdate;
        }

    }
}
