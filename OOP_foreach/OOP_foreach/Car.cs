using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_foreach
{
    class Car
    {
        string _regNr;
        public Car (string regnr)
        {
            this._regNr = regnr;
        }

        public override string ToString()
        {
            return this._regNr;
        }
    }
}
