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

namespace RottenTomatoes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<MovieData> MovieDatas = new List<MovieData>();
        public MainWindow()
        {
            InitializeComponent();

            //string[] lines = File.ReadAllLines("rotten_tomatoes_movies");
            var lines = File.ReadAllLines("rotten_tomatoes_movies").Skip(1);


            //      1                  2            3           4                    5         6        7       8        9          10                          11              12         13                     14                15                  16                  17              18              19          20                                      21                              22                              
            //rotten_tomatoes_link movie_title movie_info critics_consensus   content_rating genres  directors authors actors original_release_date   streaming_release_date runtime production_company tomatometer_status  tomatometer_rating tomatometer_count   audience_status audience_rating audience_count tomatometer_top_critics_count   tomatometer_fresh_critics_count tomatometer_rotten_critics_count

            foreach (var line in lines)
            {
                MovieDatas.Add(new MovieData(line));
            }

            /*for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(",");

                MovieData info = new MovieData();
            }*/
        }

        private void lstRottenTomatoData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
