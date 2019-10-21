using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Arv
{
    public partial class Form1 : Form
    {
        //List<Bil> bilLista = new List<Bil>();
        //List<Motorcykel> mclista = new List<Motorcykel>();
        List<Fordon> fordonsLista = new List<Fordon>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bil bil1 = new Bil("ABC123", 5);
            Motorcykel mc1 = new Motorcykel("DEF456", "Sadelfärg");
            fordonsLista.Add(bil1);
            fordonsLista.Add(mc1);


        }
    }
}
