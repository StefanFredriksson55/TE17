using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Static
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car myCar = new Car("Volvo");
            Car.carList.Add(myCar);            
            Car.carList.Add(new Car("Saab"));

            Car.minMetod();

            Random myRandom = new Random();
            int a = myRandom.Next(1, 7);


            double pi = Math.PI;

        }
    }
}
