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

namespace _P__JSON___Serialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            List<Game> GList = new List<Game>();
            InitializeComponent();

            string[] file = File.ReadAllLines("all_games.csv");

            for (int i = 1; i < file.Length; i++)
            {
                string files = file[i];
                string[] pieces = files.Split(",");

                Game system = new Game();
                //  0      1          2         3         4          5
                //name,platform,release_date,summary,meta_score,user_review

                system.name = pieces[0];
                system.platform = pieces[1];
                DateTime releaseDate = Convert.ToDateTime(pieces[2]);
                system.release_date = releaseDate;
                system.summary = pieces[3];
                double metaScore = Convert.ToDouble(pieces[4]);
                system.meta_score = metaScore;
                double userReview;
                if (double.TryParse(pieces[5], out userReview) == false)
                {
                    return;
                }
                system.user_review = userReview;
                //Create List for Later Use
                GList.Add(system);

                //Reduce Redundancy in the ComboBox
                if (cboPlatform.Items.Contains("All") == false)
                {
                    cboPlatform.Items.Add("All");
                }
                else if (cboPlatform.Items.Contains(system.platform) == false)
                {
                    cboPlatform.Items.Add(system.platform);
                }
            }
        }

        private void cboPlatform_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = new Uri(GL)
        }
    }
}
