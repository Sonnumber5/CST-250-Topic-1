using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
    class Program
    {
        static Store carStore = new Store();
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Welcome to the car Store. First you must create some cars and put them" +
                "into the store inventory. Then you may add cars to the cart. Finally, you may checkout, which " +
                "will calculate your total bill");
            int action = chooseAction();
            while (action != 0)
            {
                switch (action)
                {
                    case 1:
                        Console.Out.WriteLine("You chose to add a new car to the store:");

                        String carMake = "";
                        String carModel = "";
                        Decimal carPrice = 0;
                        bool carNew = false;
                        String carColor = "";

                        Console.Out.WriteLine("What is the car make?");
                        carMake = Console.ReadLine();

                        Console.Out.WriteLine("What is the car model?");
                        carModel = Console.ReadLine();

                        Console.Out.WriteLine("What is the car price? Numbers only");
                        carPrice = decimal.Parse(Console.ReadLine());

                        Console.Out.WriteLine("Is the car new?");
                        String condition = Console.ReadLine();
                        if (condition.Equals("yes"))
                        {
                            carNew = true;
                        }
                        else
                        {
                            carNew = false;
                        }

                        Console.Out.WriteLine("What is the car color?");
                        carColor = Console.ReadLine();

                        Car newCar = new Car();
                        newCar.make = carMake;
                        newCar.model = carModel;
                        newCar.price = carPrice;
                        newCar.isNew = carNew;
                        newCar.color = carColor;
                        carStore.carList.Add(newCar);
                        printStoreInventory(carStore);
                        break;

                    case 2:
                        printStoreInventory(carStore);
                        int choice = 0;
                        Console.Out.Write("Which car would you like to add to the car? (number)");
                        choice = int.Parse(Console.ReadLine());

                        carStore.shoppingList.Add(carStore.carList[choice]);

                        printStoreInventory(carStore);
                        break;

                    case 3:
                        printStoreInventory(carStore);
                        Console.Out.WriteLine("Your total cost is ${0}", carStore.checkout());
                        break;

                    default:
                        break;


                }
                action = chooseAction();
            }
        }

        public static void printStoreInventory(Store carStore)
        {
            Console.Out.WriteLine("These are the cars in the store inventory: ");
            int i = 0;
            foreach (var c in carStore.carList)
            {
                Console.Out.WriteLine(String.Format("Car # = {0} {1} ", i, c.Display));
                i++;
            }
        }

        public static void printShoppingCart(Store carStore)
        {
            Console.Out.WriteLine("These are the cars in your shopping cart");
            int i = 0;
            foreach (var c in carStore.shoppingList)
            {
                Console.Out.WriteLine(String.Format("Car # = {0} {1} ", i, c.Display));
            }
        }

        public static int chooseAction()
        {
            int choice = 0;
            Console.Out.WriteLine("Choose an action (0) quit (1) add a car (2) add item to cart (3) checkout");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}