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
            lblVowels.Visibility = Visibility.Hidden;
            lblConsonants.Visibility = Visibility.Hidden;
        }        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Vowels;
            string Consonants;
            new List<char> Vowels = 
            foreach (var letter in txtName.Text.ToLower())
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {

                    Vowels = txtName.Text;
                    lblVowels.Items.Add(letter);
                }
                else
                {
                    
                    Consonants = txtName.Text;
                }
            }






            lblVowels.Content = $"{Vowels}";
            lblConsonants.Content = $"{Consonants}";

            lblVowels.Visibility = Visibility.Visible;
            lblConsonants.Visibility = Visibility.Visible;
        }

    }
}
