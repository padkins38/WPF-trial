using System;
using System.Collections.Generic;
using System.Text;

namespace _P__JSON___Serialization
{
    public class Game
    {
        public string name { get; set; }        

        public string platform     {get;set;}

        public DateTime release_date {get;set;}

        public string summary      {get;set;}

        public double meta_score   {get;set;}

        public double user_review  {get;set;}

    }
}
