using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json;

namespace _P__Chuck_Norris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cboCategory.Items.Clear();
            cboCategory.Items.Add("all");
            
            using (var client = new HttpClient())
            {

                string jsonData = client.GetStringAsync("https://api.chucknorris.io/jokes/categories").Result;
                var results = JsonConvert.DeserializeObject<List<string>>(jsonData);
                
                foreach (var category in results)
                {
                    cboCategory.Items.Add(category);
                }
            }
        }

        private void btnCategory_Click(object sender, RoutedEventArgs e)
        {
            var selecteditem = cboCategory.SelectedItem;                                        
            string category = cboCategory.SelectedValue.ToString();

            string url = "https://api.chucknorris.io/jokes/random?category=";

            url += category;

            if (category.ToLower() == "all")
            {
                url = "https://api.chucknorris.io/jokes/random";
            }
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync($"{url}").Result;
                Joke joke = JsonConvert.DeserializeObject<Joke>(json);

                txtFunnyJoke.Text = joke.value;             
            }
        }
    }           //  http:// ---------------- /pokemon?offset=0&limit=1200
}               //  http:// ---------------- /pokemon/1

