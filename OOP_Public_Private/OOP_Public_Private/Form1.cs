using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Public_Private
{
    public partial class Form1 : Form
    {
        Student[] studentlista = new Student[100];
        int antalStudenter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student s1 = new Student("Stefan");
            studentlista[antalStudenter++] = s1;


            Student s2 = new Student("Jenny");            
            //s1.printInfo();
            MessageBox.Show(s1.getNamn());
            MessageBox.Show(s1.Namn);
            s1.setNamn("Hugo");
            s1.Namn = "Hugo";
            //s1.printInfo();
        }
    }
}
