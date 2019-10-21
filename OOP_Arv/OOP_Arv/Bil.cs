using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Arv
{
    class Bil : Fordon
    {
        int _antalDörrar;

        public Bil(string regnr, int antaldörrar):base(regnr)
        {
            this._antalDörrar = antaldörrar;
            MessageBox.Show("Nu skapades en Bil");
        }

    }
}
