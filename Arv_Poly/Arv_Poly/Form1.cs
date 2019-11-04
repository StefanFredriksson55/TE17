using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arv_Poly
{    
    public partial class Form1 : Form
    {
        List<Djur> djurLista = new List<Djur>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hund h = new Hund("Hunden");
            djurLista.Add(h);
            djurLista.Add(new Katt("Katten"));
            
            foreach(Djur d in djurLista)
            {
                d.beskrivning();
                //if (d is Hund)
                //{
                //    Hund tempHund = d as Hund;
                //    tempHund.beskrivning();
                //}
                //else if (d is Katt)
                //{
                //    Katt tempKatt = d as Katt;
                //    tempKatt.beskrivning();
                //}
                
            }
        }
    }
}
