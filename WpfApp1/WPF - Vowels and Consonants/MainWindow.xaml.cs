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
            ListVowels.Visibility = Visibility.Hidden;
            ListConsonants.Visibility = Visibility.Hidden;
        }        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListVowels.Items.Clear();
            ListConsonants.Items.Clear();

            string Vowels;
            string Consonants;
            foreach (var letter in txtName.Text.ToLower())
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {

                    Vowels = txtName.Text;
                    ListVowels.Items.Add(letter);
                }
                else
                {
                    
                    Consonants = txtName.Text;
                    ListConsonants.Items.Add(letter);
                }
            }






            /*ListVowels.Content = $"{Vowels}";
            ListConsonants.Content = $"{Consonants}";*/

            ListVowels.Visibility = Visibility.Visible;
            ListConsonants.Visibility = Visibility.Visible;
        }

    }
}
