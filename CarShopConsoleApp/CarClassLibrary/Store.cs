using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Store
    {
        public List<Car> carList { get; set; }
        public List<Car> shoppingList { get; set; }

        public Store()
        {
            this.carList = new List<Car>();
            this.shoppingList = new List<Car>();
        }

        public decimal checkout()
        {
            decimal totalCost = 0;

            foreach (var c in shoppingList)
            {
                totalCost += c.price;
            }

            shoppingList.Clear();

            return totalCost;
        }
    }
}
