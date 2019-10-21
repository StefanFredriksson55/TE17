using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    class Motorcykel : Fordon
    {
        string _någotSpecielltFörMc;
        public Motorcykel(string regnr, string någotspeciellt)
        {
            this._regNr = regnr;
            this._någotSpecielltFörMc = någotspeciellt;
        }
    }
}
