using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopGUI
{
    public class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public decimal price { get; set; }

        public bool isNew { get; set; }

        public String color { get; set; }

        public Car(string make, string model, decimal price, bool isNew, string color)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.isNew = isNew;
            this.color = color;
        }
        public Car()
        {
            this.make = "Nothing yet";
            this.model = "Nothing yet";
            this.price = 0;
            this.isNew = false;
            this.color = "Nothing yet";
        }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} ${2} {3} {4}", make, model, price, isNew, color);
            }
        }
    }
}
