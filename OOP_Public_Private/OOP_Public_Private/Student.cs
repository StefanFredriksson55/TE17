using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Public_Private
{
    class Student
    {
        //Variabler
        private string namn;
        public Student(string n)
        {
            this.namn = n;
        }

        public void printInfo()
        {
            MessageBox.Show("Eleven heter" + this.namn);
        }

        public string getNamn()
        {
            return this.namn;
        }
        public void setNamn(string n)
        {
            if (n.Length > 0)
            {
                this.namn = n;
            }            
        }

        public string Namn
        {
            get
            {
                return this.namn;
            }
            set
            {
                if (value.Length > 0)
                {
                    this.namn = value;
                }
                
            }
        }
    }
}
