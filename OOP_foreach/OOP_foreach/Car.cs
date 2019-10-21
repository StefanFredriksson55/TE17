using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_foreach
{
    class Car
    {
        string _regNr;
        Form1 _f1;
        TextBox _tbxForm1;
        public Car (string regnr)
        {
            this._regNr = regnr;
        }

        public Car(Form1 f1)
        {
            this._f1 = f1;
        }

        public Car (TextBox tbxForm1)
        {
            this._tbxForm1 = tbxForm1;
            this._tbxForm1.Text = "OMG";
            
        }

        public override string ToString()
        {
            //this._f1.doSomething();
            //Form1.doSomethingStatic();
            //this._tbxForm1.Text = "Text";
            return this._regNr;
            
        }

    }
}
