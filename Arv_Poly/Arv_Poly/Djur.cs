using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Arv_Poly
{
    class Djur
    {
        protected string _namn;
        public Djur(string namn)
        {

        }
        public virtual void beskrivning()
        {
            MessageBox.Show("Jag är ett djur");
        }
    }
}
