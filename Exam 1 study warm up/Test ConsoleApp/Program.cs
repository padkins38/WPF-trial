using System;

namespace Test_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string urlFront = "https://rickandmortyapi.com/api/character?page=";
            double page = 1;


            string url2 = string.Concat(urlFront, page);

            while (page < 35)
            {
                string url = ($"{urlFront}{page.ToString()}");
                Console.WriteLine($"{url} | {url2}");


                page++;
            }
        }       
    }
}
