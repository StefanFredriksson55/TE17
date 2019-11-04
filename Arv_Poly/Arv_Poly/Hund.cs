using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arv_Poly
{
    class Hund : Djur
    {
        public Hund(string namn):base(namn)
        {

        }
        public override void beskrivning()
        {
            MessageBox.Show("Jag är en hund");
        }
    }
}
