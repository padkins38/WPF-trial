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

namespace Contacts_attempt_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            string[] lines = File.ReadAllLines("contacts.txt");

            //Id|FirstName|LastName|Email|Photo
            //1 | Kerwinn | Moriarty | kmoriarty0@state.gov | https://kelicommheadshots.com/wp-content/uploads/2019/02/Jen-for-Social-Media-2-256x256.jpg

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split("|");

                Contacts c = new Contacts();

                int id = Convert.ToInt32(pieces[0]);
                c.Id = id;
                c.FirstName = pieces[1];
                c.LastName  = pieces[2];
                c.Email     = pieces[3];
                c.Photo = pieces[4];

                LstBoxContacts.Items.Add(c);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Contacts selectedContact = (Contacts)LstBoxContacts.SelectedItem;

            txtFirstName.Text = selectedContact.FirstName;
            txtLastName.Text = selectedContact.LastName;
            txtEmail.Text = selectedContact.Email;

            var uri = new Uri(selectedContact.Photo);
            var img = new BitmapImage(uri);
            imgProfile.Source = img;


        }
    }
}
