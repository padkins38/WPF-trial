using System;
using System.Collections.Generic;
using System.IO;
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

namespace _P__GOT_Quote
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<GameOfThronesAPI> apiQuoteList = new List<GameOfThronesAPI>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetQuote_Click(object sender, RoutedEventArgs e)
        {
            lblCharacter.Content = string.Empty;

            using (var client = new HttpClient())
            {
                string url = $"https://got-quotes.herokuapp.com/quotes";

                string jsonData = client.GetStringAsync(url).Result;
                GameOfThronesAPI api = JsonConvert.DeserializeObject<GameOfThronesAPI>(jsonData);
                lblCharacter.Content = api.character;
                lblQuote.Content = api.quote;

                apiQuoteList.Add(api);
            }
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(apiQuoteList);
            File.WriteAllText("GOT_Quotes.json", json);

            //ex new window
            wndExample ex = new wndExample();

            ex.DoSomething();

            ex.Show();

        }
    }
}