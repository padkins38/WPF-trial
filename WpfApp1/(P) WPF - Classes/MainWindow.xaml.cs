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
            List<Toy> toys = new List<Toy>();

            //instance 1 for toy
            Toy t1 = new Toy();

            t1.Manufacturer = "Beulah's Candyland";
            t1.Name = "Milk Chocolate Peanut Clusters 2 pounds";
            t1.Price = 23.00;
            t1.GetAisle();

            toys.Add(t1);

            foreach (var toy in toys)
            {
               ;
            }
        }
    }
}
