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

namespace _P__Rick_And_Morty__AddCharToCboBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cboCharacters.Items.Clear();

            using (var client = new HttpClient())
            {
                string urlFront = "https://rickandmortyapi.com/api/character?page=";
                double page = 1;

                while (page < 35) //need to update
                {
                    string url = string.Concat(urlFront, page.ToString());
                    string jsonData = client.GetStringAsync(url).Result;


                    RickAndMortyAPI api = JsonConvert.DeserializeObject<RickAndMortyAPI>(jsonData);

                    foreach (Character item in api.results)
                    {
                        cboCharacters.Items.Add(item);
                    }
                    page++;
                }
            }
           
            //CharactersList = https://rickandmortyapi.com/api/character
        }
    }
}
