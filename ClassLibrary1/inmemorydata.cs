using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;


namespace Servicelager    //Klasser = Behörighet, Anvandare, Lokal, Program, Kurs
{




    public static class Program
    {
        public static void Main()
        {
            // Main method implementation
        }
    }


    public class AnvandareRepository 
    {
        private List<User> _anvandareLista; // Lista med användare

        public AnvandareRepository()
        {
            
            _anvandareLista = new List<User>
                { // LÖSENORD FÖR ALLA ANVÄNDARE ÄR 123, USERID ÄR INLOGG. ALLA ANVÄNDARE MED USERID <=3 ÄR ADMINISTRATÖRER, ÖVRIGA ÄR ANVÄNDARE. USERID ÄR DET FÖRSTA ATTRIBUTET I LISTAN.
                    new User(1, "Alice", "Karlsson", 980101, 701234567, "alice.karlsson@gmail.com", "123", 1),
                    new User(2, "Gustav", "Karlholm", 960101, 732345678, "gustav.karlholm@protonmail.com", "123", 1),
                    new User(3, "Kajsa", "Josefsson", 960101, 763456789, "kajsa.josefsson@hb.com", "123", 1),
                    new User(4, "Gideon", "Lindgren", 860101, 794567890, "gideon.lindgren@raceoffice.com", "123", 2),
                    new User(5, "Johannes", "Pettersson", 430101, 705678901, "johannes.pettersson@hb.com", "123", 2),
                    new User(6, "Yasmine", "Nilsson", 320606, 736789012, "yasmine.nilsson@gu.org", "123", 2),
                    new User(7, "Rebecka", "Svensson", 040404, 767890123, "rebecka.svensson@chalmers.net", "123", 3),
                    new User(8, "Filip", "Olsson", 060101, 798901234, "filip.olsson@havard.co", "123", 3),
                    new User(9, "Millie", "Karlsson", 1010101, 709012345, "millie.karlsson@cambridge.edu", "123", 3),
                    new User(10, "Dag", "Hansson", 010101, 730123456, "dag.hansson@enterprise.biz", "123",3 ),
                    new User(11, "Ia", "Persson", 001001, 761234567, "ia.persson@provider.io", "123",3 )
                };
        }


        public User GetAllAnvandare(int UserID, string password)
        {
            // Söker efter användare med matchande förnamn och lösenord
            return _anvandareLista.FirstOrDefault(user =>
        user.UserID.Equals(UserID) && user.Password == password);

        }
    }

    public class StationRepository
    {
        private List<StationData> _stationList; // Lista med stationdata

        public StationRepository()
        {
            // Initialiserar data
            _stationList = new List<StationData> // Lista med stationdata
                {
                    new StationData("Allégatan", 10, "Tillänglig", 5),
                    new StationData("Stationsgatan", 5, "På Underhåll", 5),
                    new StationData("Fredriksbergsgatan", 8, "Fullbokat", 5),
                    new StationData("Solrosvägen", 12, "Tillgänglig", 5)
                };
        }

        public List<StationData> GetAllStationer() // Retunerar en lista med alla stationer
        {
            return _stationList;
        }
    }

    public class UthyrningsHistorikRepository 
    {
        private List<UthyrningsHistorik> _uthyrningshistoriklist; // Lista med uthyrningsdata


        public UthyrningsHistorikRepository() 
        {
            // Initialiserar data
            _uthyrningshistoriklist = new List<UthyrningsHistorik> 
                {
                    new UthyrningsHistorik(new DateTime(2024, 10, 22, 10, 30, 0), new DateTime(2024, 10, 22, 12, 30, 0), 5, 10),
                    new UthyrningsHistorik(new DateTime(2024, 10, 23, 9, 0, 0), new DateTime(2024, 10, 23, 11, 15, 0), 6, 10),
                    new UthyrningsHistorik(new DateTime(2024, 10, 24, 14, 0, 0), new DateTime(2024, 10, 24, 16, 0, 0), 7, 10),
                    new UthyrningsHistorik(new DateTime(2024, 10, 25, 8, 30, 0), new DateTime(2024, 10, 25, 10, 30, 0), 8, 10),
                    new UthyrningsHistorik(new DateTime(2024, 10, 26, 13, 15, 0), new DateTime(2024, 10, 26, 14, 45, 0), 4, 10),
                    new UthyrningsHistorik(new DateTime(2024, 10, 27, 11, 0, 0), new DateTime(2024, 10, 27, 12, 30, 0), 5, 10)
                };
        }

        public List<UthyrningsHistorik> GetAllUthyrningsHistorik() // Retunerar en lista med alla uthyrningsdata
        {
            return _uthyrningshistoriklist;
        }

        public void AddUthyrningsHistorik(UthyrningsHistorik data) // Lägger till uthyrningsdata i listan
        {
            _uthyrningshistoriklist.Add(data);
        }
    }

    public class KontoDataRepository 
    {
        private List<KontoData> _kontoDatalist; // Lista med kontodata

        public KontoDataRepository()
        {
            _kontoDatalist = new List<KontoData> // Lista med kontodata
                {
                    new KontoData(new DateTime(2024, 10, 22), "Mastercard"),
                    new KontoData(new DateTime(2024, 10, 23), "Swish"),
                    new KontoData(new DateTime(2024, 10, 24), "Mastercard"),
                    new KontoData(new DateTime(2024, 10, 25), "Mastercard"),
                    new KontoData(new DateTime(2024, 10, 26), "Mastercard")
                };
        }

        public List<KontoData> GetAllKontoData() // Retunerar en lista med alla kontodata
        {
            return _kontoDatalist;
        }

        public void AddKontoData(KontoData kontoData) // Lägger till kontodata i listan
        {
            _kontoDatalist.Add(kontoData);
        }

        public KontoData GetKontoDataByDate(DateTime hyrHistorik) // Retunerar kontodata baserat på datum
        {
            return _kontoDatalist.FirstOrDefault(k => k.HyrHistorik == hyrHistorik); // Returnerar första elementet som matchar datumet
        }
    }
    }
    
public class FordonRepository
{
    private static List<Fordon> _fordonLista; // Lista med fordon

    static FordonRepository() // Konstruktor
    {
        _fordonLista = new List<Fordon>
        {
            new Fordon(1, "Allégatan", 100, "Ledig", "Elcykel"),
            new Fordon(2, "Stationsgatan", 100, "Ledig", "Elsparkcykel"),
            new Fordon(3, "Solrosvägen", 50,  "Laddas", "Elsparkcykel"),
            new Fordon(4, "Allégatan", 50, "Laddas", "Elcykel"),
            new Fordon(5, "Stationsgatan",30,  "Laddas", "Elcykel"),
            new Fordon(6, "Stationsgatan", 100, "Ledig", "Elsparkcykel"),
            new Fordon(7, "Solrosvägen", 10, "Laddas", "Elsparkcykel"),
            new Fordon(8, "Solrosvägen", 100, "Ledig", "Elcykel"),
            new Fordon(9, "Fredriksbergsgatan", 100, "Ledig", "Elcykel"),
            new Fordon(10, "Fredriksbergsgatan", 5, "Laddas", "Elsparkcykel")
        };
    }
    public static void UpdateFordon(Fordon fordon)
    {
        var existingFordon = _fordonLista.FirstOrDefault(f => f.FordonsID == fordon.FordonsID);
        if (existingFordon != null)
        {
            // Uppdatera fordonets status eller andra egenskaper
            existingFordon.Status = fordon.Status;
            // Lägg till andra uppdateringar här om det behövs
        }
        else
        {
            // Om fordonet inte finns, kan du lägga till det (eller hantera det som ett fel)
            _fordonLista.Add(fordon);
        }
    }


    public static List<Fordon> GetAllFordon() // Retunerar en lista med alla fordon
    {
        return _fordonLista;
    }
    public Fordon GetFordonById(int fordonsID)
    {
        // Här ska din logik för att hämta ett fordon baserat på ID finnas
        return _fordonLista.FirstOrDefault(f => f.FordonsID == fordonsID);
    }

}

public class StationRepository
{
    private List<StationData> _stationList; // Lista med stationdata

    public StationRepository()
    {
        // Initialiserar data
        _stationList = new List<StationData> // Lista med stationdata
            {
                new StationData("Allégatan", 10, "Tillänglig", 20),
                new StationData("Stationsgatan", 5, "På Underhåll", 50),
                new StationData("Fredriksbergsgatan", 8, "Fullbokat", 100),
                new StationData("Solrosvägen", 12, "Tillgänglig", 25)
            };
    }

    public List<StationData> GetAllStationer() // Retunerar en lista med alla stationer
    {
        return _stationList;
    }
}