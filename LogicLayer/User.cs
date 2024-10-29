using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{


    public class User //Definierar vilken data som finns kring Användare, om man tex skulle behöva lägga till/ta bort en Användare.
    {
        public int UserID { get; }
        public string Fornamn { get; }
        public string Efternamn { get; }
        public int Personnummer { get; }
        public long Telefonnr { get; }
        public string Epost { get; }
        public string Password { get; }
        public User(int userID, string fornamn, string efternamn, int personnummer, long telefonnr, string epost, string password)
        {
            UserID = userID;
            Fornamn = fornamn;
            Efternamn = efternamn;
            Personnummer = personnummer;
            Telefonnr = telefonnr;
            Epost = epost;
            Password = password;
        }
    }   
    
}
//test