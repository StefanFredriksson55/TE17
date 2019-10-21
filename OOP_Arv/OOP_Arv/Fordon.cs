using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Arv
{
    class Fordon
    {
        protected string _regNr;

        public Fordon(string regnr)
        {
            this._regNr = regnr;
            MessageBox.Show("Nu skapades ett fordon");
        }

        public Fordon()
        {

        }
    }
}
