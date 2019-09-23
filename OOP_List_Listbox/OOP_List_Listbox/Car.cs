using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_List_Listbox
{
    class Car
    {
        string _brand;
        string _regNr;

        public Car(string brand, string regnr)
        {
            this._brand = brand;
            this._regNr = regnr;
            MessageBox.Show("Nu skapades en bil");
        }

        public string Brand
        {
            get
            {
                return this._brand;
            }
        }

        public override string ToString()
        {
            return "Märke: " + this._brand + " Regnr: " + this._regNr;
        }
    }
}
