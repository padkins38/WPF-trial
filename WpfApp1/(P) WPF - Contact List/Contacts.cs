using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace _P__WPF___Contact_List
{
    public class Contacts
    {
        public int ID {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string URL {get; set;}
        public SerializationInfo Image { get; internal set; }

        public Contacts()
        {
            ID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            URL = string.Empty;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }






    }
}
