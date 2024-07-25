using System;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store store = new Store();

        BindingSource carListBinding = new BindingSource();
        BindingSource shoppingListBinding = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            SetBindings();
        }

        private void SetBindings()
        {
            carListBinding.DataSource = store.carList;
            listBox1.DataSource = carListBinding;
            listBox1.DisplayMember = "Display";
            listBox1.ValueMember = "Display";

            shoppingListBinding.DataSource = store.shoppingList;
            listBox2.DataSource = shoppingListBinding;
            listBox2.DisplayMember = "Display";
            listBox2.ValueMember = "Display";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Car newCar = new Car
                {
                    make = textBox1.Text,
                    model = textBox2.Text
                };

                if (!decimal.TryParse(textBox3.Text, out decimal price))
                {
                    MessageBox.Show("wrong price format");
                    return;
                }
                newCar.price = price;

                if (!bool.TryParse(textBox4.Text, out bool isNew))
                {
                    MessageBox.Show("Write true or false");
                    return;
                }
                newCar.isNew = isNew;

                newCar.color = textBox5.Text;

                store.carList.Add(newCar);
                carListBinding.ResetBindings(false);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred:");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car selectedCar = (Car)listBox1.SelectedItem;
            if (selectedCar != null)
            {
                store.shoppingList.Add(selectedCar);
                shoppingListBinding.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Please select a car to add to the shopping cart.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal total = store.checkout();
            label5.Text = total.ToString();
        }
    }
}
