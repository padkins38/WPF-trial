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

namespace _P__WPF___Contact_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string file = "Contacts.txt";
            string[] lines = File.ReadAllLines(file);
           


            for (int i = 1; i < lines.Length; i++)
            {
                /*Id | FirstName | LastName | Email                | Photo
                1    | Kerwinn   | Moriarty | kmoriarty0@state.gov | https://kelicommheadshots.com/wp-content/uploads/2019/02/Jen-for-Social-Media-2-256x256.jpg*/

                string line = lines[i];
                string[] pieces = line.Split("|");

                // pieces[0] = *Id
                // pieces[1] = FirstName
                // pieces[2] = LastName
                // pieces[3] = Email
                // pieces[4] = Photo

                Contacts s = new Contacts();
                int id = Convert.ToInt32(pieces[0]);
                s.ID = id;
                s.FirstName = pieces[1];
                s.LastName = pieces[2];
                s.Email = pieces[3];
                s.URL = pieces[4];

                LstBoxContacts.Items.Add(s);
            }



        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Contacts s = (Contacts)LstBoxContacts.SelectedItem;
            txtFirstName.Text = s.FirstName;
            txtLastName.Text = s.LastName;
            txtEmail.Text = s.Email;

            var uri = new Uri(s.URL);
            var img = new BitmapImage(uri);
            imgProfile.Source = img;
        }
    }
}
