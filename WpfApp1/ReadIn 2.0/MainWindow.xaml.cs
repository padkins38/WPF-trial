using System;
using System.Collections.Generic;
using System.IO;
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

namespace ReadIn_2._0
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string file = txtlink.Text;

            string[] contents = File.ReadAllLines(file);

            for (int i = 0; i < contents.Length; i++)
            {
                //   0                1        2           3           4         5           6       etc
                //1/2/2009 6:17   Product1     1200    Mastercard  Carolina    Basildon    England
                string line = contents[i];

                string[] pieces = line.Split(",");

                //pieces[0] = "1/2/2009 6:17"
                //pieces[1] = "Product1
                //pieces[2] = "1200"
                //pieces[3] = "Mastercard
                //pieces[4] = "Carolina"


                /*With a calss
                DateTime tDate = Convert.ToDateTime(pieces[0]);
                string product = pieces[1];
                string price = pieces[2];
                SalesData s = new SalesData();
                s.Transaction_Date = tDate;
                s.Product = product;
                s.Price = price;*/




                string paymentType = pieces[3]; //the mastercard

                if (paymentType == "Mastercard")
                {
                    lstBox.Items.Add(line);
                }
            }
        }

        private void bttnWrite_Click(object sender, RoutedEventArgs e)
        {
            string file = @"C:\Users\padki\Downloads\output.txt";

            string contents = "This is a line in the new file";

            File.WriteAllText(file, contents);

            string file2 = @"C:\Users\padki\Downloads\output2.txt";

            string[] output = new string[lstBox.Items.Count];
            for (int i = 0; i < lstBox.Items.Count; i++)
            {
                output[i] = (string)lstBox.Items.GetItemAt(i);
            }
        }
    }
}
