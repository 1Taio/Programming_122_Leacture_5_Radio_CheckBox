using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Programming_122_Leacture_5_Radio_CheckBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Preload();

        }

        void Preload()
        {
            rbSmall.IsChecked = true;
            rbSmallDrink.IsChecked = true;
        }

        private void btnCheckBoxResult_Click(object sender, RoutedEventArgs e)
        {

            //checkbox name, Is.Checked.Vaule
            bool isChecked = ckFirstCheckBox.IsChecked.Value;


            MessageBox.Show(isChecked.ToString());
        }

        private void btnOrderPizza_Click(object sender, RoutedEventArgs e)
        {

            runReciept.Text = txtCustomerName.Text + "\n";
           
            double amount = 0;

            //inputs
            //outputs
            //loops
            //conidtions
            //varibles
            //operators

            bool hasPepperoni = ckPepperoni.IsChecked.Value;
            bool hasCheese = ckCheese.IsChecked.Value;
            bool hasMushrooms = ckMushroom.IsChecked.Value;
            bool hasPineapple = ckPineapple.IsChecked.Value;

            bool sizeSmall = rbSmall.IsChecked.Value;
            bool sizeMedium = rbMeduim.IsChecked.Value;
            bool sizeLarge = rbLarge.IsChecked.Value;
            bool sizeExtraLarge = rbExtraLarge.IsChecked.Value;

            bool drinkSmall = rbSmallDrink.IsChecked.Value;
            bool drinkMeduim = rbMeduimDrink.IsChecked.Value;
            bool drinkLarge = rbLargeDrink.IsChecked.Value;
            bool drinkExtraLarge = rbExtraLargeDrink.IsChecked.Value;


            double price = 0;

            if (sizeSmall)
            {
                price = 13;
                runReciept.Text += "Small\n";
               

            }
            else if (sizeMedium)
            {
                price = 15;
                runReciept.Text += "Medium\n";
             
            }
            else if (sizeLarge)
            {
                price = 18;
                runReciept.Text += "Large\n";
                
            }
            else if (sizeExtraLarge)
            {
                price = 25;
                runReciept.Text += "Extra Large\n";
           
            }

           
          
            else
            {
                MessageBox.Show("Please choose a pizza size");
            }

            runReciept.Text += " - " + price.ToString("c");
            amount += price;


            runReciept.Text += "Toppings:\n";

            if (hasPepperoni == true)
            {
                double toppingprice = 4;
                runReciept.Text += $"Pepperoni -{toppingprice.ToString("c")}\n";
                amount += toppingprice;
            }
            if (hasCheese)
            {
                double toppingprice = 6;
                runReciept.Text += $"Mushrooms -{toppingprice.ToString("c")}\n";
                amount += toppingprice;
            }
            if (hasMushrooms)
            {
                double toppingprice = 5;
                runReciept.Text += $"Cheese -{toppingprice.ToString("c")}\n";
                amount += toppingprice;
            }
            if (hasPineapple)
            {
                double toppingprice = 5;
                runReciept.Text += $"Pineapple -{toppingprice.ToString("c")}\n";
                amount += toppingprice;
            }


            // SIZE OF THE DRINKS
            runReciept.Text += "\nDrinks";

            if (drinkSmall)
            {
                double drinkprice = 2.50;
                runReciept.Text += $"Small Drink -{drinkprice.ToString("c")}\n";
                amount += drinkprice;

            }
            else if (drinkMeduim)
            {
                double drinkprice = 3.50;
                runReciept.Text += $"Medium Drink -{drinkprice.ToString("c")}\n";
                amount += drinkprice;
            }
            else if (drinkLarge)
            {
                double drinkprice = 4.50;
                runReciept.Text += $"Large Drink -{drinkprice.ToString("c")}\n";
                amount += drinkprice;
            }
            else if (drinkExtraLarge)
            {
                double drinkprice = 5.50;
                runReciept.Text += $"Small Drink -{drinkprice.ToString("c")}\n";
                amount += drinkprice;
            }

            double tax = .1;
            double calculatedTax = amount * tax;
            double totalamount = amount + tax;

            runReciept.Text += $" \n\nSub price {amount.ToString("c")}\n" +
                $"Tax AMount {calculatedTax.ToString("c")}\n" +
                $"Total Price {totalamount.ToString("c")}";

        }
    }
}
