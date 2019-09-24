using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_List_Listbox
{
    public partial class Form1 : Form
    {
        Car[] carArray = new Car[1000];
        int numberOfCars = 0;

        //En lista där Car-objekt får plats
        List<Car> carList = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreateCar_Click(object sender, EventArgs e)
        {
            string brand = tbxBrand.Text;
            string regnr = tbxRegNr.Text;
            Car c = new Car(brand, regnr);
            carList.Add(c);
            lbxCarListBox.Items.Add(c);

            //carList.Add(new Car(tbxBrand.Text, tbxRegNr.Text));
        }

        private void LbxCarListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car c = lbxCarListBox.SelectedItem as Car;
            MessageBox.Show("Du valde " + c.Brand);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Car c = lbxCarListBox.SelectedItem as Car;
            carList.Remove(c);
        }
    }
}
