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

namespace First_try
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblOutput.Visibility = Visibility.Hidden;




            TextBox txt1 = new TextBox();
            txt1.Text = "Hello WOrld";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine("Happy Boi");
        }

        private void Laser_Cannon_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("What the Dog Doin?");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("What the Dog Doin?");
            string dob = txtWhatTheDogDoin.Text;
            DateTime birthdate = Convert.ToDateTime(dob);
            TimeSpan age = DateTime.Now - birthdate;

            string name = txtName.Text;

            //MessageBox.Show((age.TotalDays / 365).ToString());

            double old = age.TotalDays / 365;

            lblOutput.Content = $"Hello {name}, you are {old.ToString("N2")}";
            lblOutput.Visibility = Visibility.Visible;

        }
    }
}
