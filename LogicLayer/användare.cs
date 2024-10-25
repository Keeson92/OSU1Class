using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessEnteties
{


    public class AnvandareData //Definierar vilken data som finns kring Användare, om man tex skulle behöva lägga till/ta bort en Användare.
    {
        public int AnvandarID { get; }
        public string Fornamn { get; }
        public string Efternamn { get; }
        public int Personnummer { get; }
        public long Telefonnr { get; }
        public string Epost { get; }
        public string Password { get; }
        public AnvandareData(int anvandarID, string fornamn, string efternamn, int personnummer, long telefonnr, string epost, string password)
        {
            AnvandarID = anvandarID;
            Fornamn = fornamn;
            Efternamn = efternamn;
            Personnummer = personnummer;
            Telefonnr = telefonnr;
            Epost = epost;
            Password = password;
        }
    }   
    
}
