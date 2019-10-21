using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_foreach
{
    public partial class Form1 : Form
    {
        List<Car> carList = new List<Car>();
        public Form1()
        {
            InitializeComponent();
            global
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carList.Add(new Car("ABC123"));
            carList.Add(new Car("DEF456"));

            for (int i = 0; i < carList.Count; i++)
            {
                MessageBox.Show(carList[i].ToString());
            }

            foreach(Car c in carList)
            {
                MessageBox.Show(c.ToString());
            }

            Car c1 = new Car(this.textBox1);


        }
        public static void doSomethingStatic()
        {
        }
        public void doSomething()
        {
            TextBox te = this.textBox1;
        }
    }
}
