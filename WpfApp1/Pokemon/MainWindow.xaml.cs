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

namespace Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PokemonInfo poke;
        private bool showFront = false;
        public MainWindow()
        {
            InitializeComponent();
            cboPokemon.Items.Clear();

            string url = "https://pokeapi.co/api/v2/pokemon?offset=0&Limit=1118";
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    PokemonList api = JsonConvert.DeserializeObject<PokemonList>(json);

                    foreach (var item in api.results)
                    {
                        cboPokemon.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show($"ERROR:{response.StatusCode}");
                }

                //Can get the same information by doing this

                /* string jsonData = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon?offset=0&Limit=1118").Result;
                 var results = JsonConvert.DeserializeObject<PokemonList>(jsonData);

                 foreach (var item in results.results)
                 {
                     cboPokemon.Items.Add(item);
                 }*/
            }
        }

        private void cboPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Results selected = (Results)cboPokemon.SelectedItem;

            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(selected.url).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    poke = JsonConvert.DeserializeObject<PokemonInfo>(json);

                    imgPokemon.Source = new BitmapImage(new Uri(poke.sprites.front_default)) ;

                }
                showFront = false;
            }

                /*txtURL.Text = string.Empty;
                var selecteditem = cboPokemon.SelectedItem;
                string category = cboPokemon.SelectedValue.ToString();

                string url = "https://pokeapi.co/api/v2/pokemon?offset=0&Limit=1118";
                url += category;

                using (var client = new HttpClient())
                {
                    string json = client.GetStringAsync($"{url}").Result;
                    var results = JsonConvert.DeserializeObject<PokemonList>(json);

                    foreach (var item in results.results)
                    {
                       lstboxURL.Items.Add(item.url);
                    }

                }*/
        }

        private void btnToggle_Click(object sender, RoutedEventArgs e)
        {
            if (showFront == true)
            {
                imgPokemon.Source = new BitmapImage(new Uri(poke.sprites.front_default));
                showFront = false;
            }
            else
            {
                imgPokemon.Source = new BitmapImage(new Uri(poke.sprites.back_default));
                showFront = true;
            }
          
        }
    }
}
