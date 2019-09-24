using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Static
{
    class Car
    {
        public static List<Car> carList = new List<Car>();
        public static int antalBilar;

        string _brand;
        public Car(string brand)
        {
            this._brand = brand;
        }

        public static void minMetod()
        {
            //
        }
    }
}
