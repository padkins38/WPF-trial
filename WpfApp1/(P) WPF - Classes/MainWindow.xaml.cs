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

namespace _P__WPF___Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bttn_Activate_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txt_URL.Text) == true)
            {
                isValid = false;
                txt_Manufacturer_Name.Text = string.Empty;
                MessageBox.Show("Invalid entry for the URL");
            }
            if (string.IsNullOrWhiteSpace(txt_Manufacturer_Name.Text) == true)
            {
                isValid = false;
                txt_Manufacturer_Name.Text = string.Empty;
                MessageBox.Show("Invalid entry for manufacturer");
            }
            if (string.IsNullOrWhiteSpace(txt_Toy_Name.Text) == true)
            {
                isValid = false;
                txt_Manufacturer_Name.Text = string.Empty;
                MessageBox.Show("Invalid entry for the toy name");
            }
            /*if(string.IsNullOrWhiteSpace(txt_Toy_Price.Text) == true)
            {
                isValid = false;
                txt_Manufacturer_Name.Text = string.Empty;
                MessageBox.Show("Invalid entry for toy price");
            }*/
            double price;
            if (double.TryParse(txt_Toy_Price.Text, out price) == false)
            {
                isValid = false;
                //txtPrice.Text = "";// string.Empty;
                MessageBox.Show("Invalid entry for Price.");
            }
            ////////////////
            if (isValid == false)
            {
                return;
            }

            Toy t = new Toy();
            t.Image = txt_URL.Text;
            t.Manufacturer = txt_Manufacturer_Name.Text;
            t.Name = txt_Toy_Name.Text;
            t.Price = price;

            ListBox_1.Items.Add(t);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Toy selectedToy = (Toy)ListBox_1.SelectedItem;
            MessageBox.Show(selectedToy.GetAisle());

            var uri = new Uri(selectedToy.Image);
            var img = new BitmapImage(uri);

            imgToy.Source = img;

            //imgToy.Source = new BitmapImage(new Uri(selectedToy.Image));

        }








        /*Toy selectedToy = (Toy)lstToys.SelectedItem;
        MessageBox.Show(selectedToy.GetAisle());

            var uri = new Uri(selectedToy.Image);
        var img = new BitmapImage(uri);

        imgToy.Source = img;*/
    }
}

