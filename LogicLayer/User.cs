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

        public int Behörighetsgrad { get; }


        public User(int userID, string fornamn, string efternamn, int personnummer, long telefonnr, string epost, string password, int behörighetsgrad) //Konstruktor för User
        {
            UserID = userID;
            Fornamn = fornamn;
            Efternamn = efternamn;
            Personnummer = personnummer;
            Telefonnr = telefonnr;
            Epost = epost;
            Password = password;
            Behörighetsgrad = behörighetsgrad;
        }


        public List<UthyrningsHistorik> UthyrningsHistorik { get; set; } // En användare kan hyra flera fordon.
        public KontoData KontoData { get; set; } // En användare har exakt ett konto.

    }

}
// Så här hade det sett ut om fokus låg på inloggning, men vi har hårdkodat att systemadministratör är Username 1, 2 eller 3 med password 123, och privatperson har username 4, 5 eller 6 och uppåt med lösenord 123.