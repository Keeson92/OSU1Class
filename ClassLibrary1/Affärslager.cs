using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using BusinessEntities;

namespace Servicelager
{
    public class Affärslager
    {

        public static void HyraFordon()
        {
            //för att deklarera våra controllers
            AnvandareRepository anvandareRepository = new AnvandareRepository();

            List<AnvandareData> anvandareList = anvandareRepository.GetAllAnvandare();

            FordonRepository fordonRepository = new FordonRepository();

            List<Fordon> fordonList = fordonRepository.GetAllFordon();

            StationRepository stationRepository = new StationRepository();

            List<StationData> stationList = stationRepository.GetAllStationer();

        }

        private readonly FordonRepository _fordonRepository;
        private readonly StationRepository _stationRepository;

        public Affärslager()
        {
            _fordonRepository = new FordonRepository();
            _stationRepository = new StationRepository();
        }

        public List<Fordon> GetFordonByStation(string stationNamn)
        {
                // Hämta alla fordon och filtrera på stationsnamnet
                var allFordon = _fordonRepository.GetAllFordon();
                return allFordon.Where(f => f.Position == stationNamn).ToList();
        }
        

    }
}


            // Hämta och validera datum
           /* bool isValidDate = false;
            while (!isValidDate)
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow; // BYTER FÄRG PÅ CONSOLE!!! WOOOOOO
                Console.WriteLine();
                Console.Write("Ange ett datum (YY:MM:DD): ");
                string date = Console.ReadLine();
                if (DateTime.TryParse(date, out DateTime dateTime))
                {
                    hyraFordon.Datum = dateTime;
                    isValidDate = true;
                    Console.WriteLine($"Datumet är: {dateTime}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Ogiltigt datumformat. Försök igen.");
                }
            }

            // Hämta och validera tidsintervall
            Console.ForegroundColor = ConsoleColor.Yellow; // BYTER FÄRG PÅ CONSOLE!!! WOOOOOO
            bool isValidTimeRange = false;
            while (!isValidTimeRange)
            {
                Console.Write("Ange ett tidintervall (t.ex. 10:00-12:00): ");
                string timeRange = Console.ReadLine();
                string[] timeParts = timeRange.Split('-');
                if (timeParts.Length == 2 &&
                    TimeSpan.TryParse(timeParts[0], out TimeSpan startTime) &&
                    TimeSpan.TryParse(timeParts[1], out TimeSpan endTime) &&
                    startTime <= endTime)
                {
                    hyraFordon.StartTid = startTime;
                    hyraFordon.SlutTid = endTime;
                    isValidTimeRange = true;
                    Console.WriteLine($"Tidsintervallet är: {startTime} - {endTime}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Ogiltigt tidsintervall. Använd formatet HH:MM-HH:MM.");
                }
            }

            string Station = "";
            bool isValidStation = false;
            while (!isValidStation)
            {
                Console.Write("StationsNamn?: ");
                Station = Console.ReadLine();
                var valdStation = stationList.FirstOrDefault(p => p.Station.Equals(Station.Namn StringComparison.OrdinalIgnoreCase));
                if (valdStation != null)
                {
                    hyraFordon.Station = valdStation.Namn;
                    Console.WriteLine($"Du skrev in: {Station}"); //validerar input
                    Console.WriteLine();

                    isValidStation = true;
                }
                else
                {
                    Console.WriteLine($"{Station} finns inte i stationslistan. Försök igen.");
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow; //byter färg igen

            string Fordon = "";
            bool isValidFordon = false;
            while (!isValidFordon)
            {
                Console.Write("Fordon?: ");
                Fordon = Console.ReadLine();
                var valdStation = fordonList.FirstOrDefault(p => p.FordonsTyp.Equals(Fordon, StringComparison.OrdinalIgnoreCase));

                if (string.IsNullOrWhiteSpace(Fordon))
                {
                    Console.WriteLine("Felaktig indata, datan måste innehålla information.");

                }
                else
                {
                    hyraFordon.Station = valdStation.Station;

                    Console.WriteLine($"Du skrev in: {Fordon}"); //validerar input
                    Console.WriteLine();
                    isValidFordon = true;
                }
            }

            Console.WriteLine($"Du skrev in: {hyraFordon.Datum:yyyy-MM-dd} - {hyraFordon.StartTid:hh\\:mm} - {hyraFordon.SlutTid:hh\\:mm} - {hyraFordon.Fordon} - {hyraFordon.Station} {hyraFordon.UppdateradTid}");
            Console.Write("Är detta korrekt? (Ja/Nej): ");
            string validation = Console.ReadLine();
            if (validation == "Ja")
            {
                //Hyrning sparas.
                string filePath = "Hyrhistorik.txt";
                DateTime now = DateTime.Now;
                hyraFordon.UppdateradTid = now; // Tidpunkt när schemat lades till
                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    string formattedSchema = $"{hyraFordon.Datum:yyyy-MM-dd} - {hyraFordon.StartTid:hh\\:mm} - {hyraFordon.SlutTid:hh\\:mm} - " +
                                             $"{hyraFordon.Fordon} - {hyraFordon.Station} - " +
                                             $"{hyraFordon.UppdateradTid}";
                    writer.WriteLine(formattedSchema);
                    writer.Flush();
                }

                Console.WriteLine("Hyrning sparad.");

            }
            else
            {
                Console.WriteLine("Hyrning sparades inte");
            }
        }
        public static void VisaHyrhistorik() //Metod för att återhämta gjorda hyrningar
        {

        }
        public static int Behörighetsgradinloggad; //Definierar vem som är behörig till vilken meny
        public static bool Login()
        {
            int searchID;
            Console.Write("AnvändarID: ");

            try // Felsäkring då användarID är en int
            {
                searchID = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Felaktig inmatning. Mata in ett giltigt AnvändarID.");
                return false;
            }
            // Skapar en instans av Användare 
            AnvandareRepository anvandareRepository = new AnvandareRepository();

            // Hämta alla användare
            List<AnvandareData> anvandareLista = anvandareRepository.GetAllAnvandare();

            // Söka efter användare genom deras ID
            var foundUser = anvandareLista.FirstOrDefault(u => u.AnvandarID == searchID);

            if (foundUser != null)
            {
                // Användare hittad, hämtar för- och efternamn.
                string firstName = foundUser.Fornamn;
                string lastName = foundUser.Efternamn;

             

                // Validerar lösenord
                if (foundUser.Password == password)
                {
                    // Lösenord är korrekt, användare loggas in
                    Console.WriteLine($"{firstName} {lastName} är nu inloggad.");
                    Behörighetsgradinloggad = foundUser.Behorighetsgrad; //Antar att Behörighetsgrad är en property av AnvandareData
                    Meny();
                    return true; // Returnerar true för ett fungerande inlogg.
                }
                else
                {
                    // Ogiltigt lösenord
                    Console.WriteLine("Felaktigt lösenord!");
                    return false; // Returnerar false för ogiltigt inlogg
                }
            }
            else
            {
                // Ingen användare hittad med givet ID
                Console.WriteLine($"{searchID} hittades inte!");
                return false; // Return false if user not found
            }
        }
        public static void Meny() //Definierar behörighetsgraden och vilken meny som visas utifrån denna.
        {
            if (Affärslager.Behörighetsgradinloggad == 2 || Affärslager.Behörighetsgradinloggad == 3)
            { UserMeny(); }
            else
            { SystemadminMeny(); }
        }
        public static void VisaFordon() //Metod för Lokaler, kontroll, lista
        {
            FordonRepository fordonRepository = new FordonRepository();

        List<FordonData> fordon = fordonRepository.GetAllFordon();
        foreach (var Fordon in fordon)
        {
            Console.WriteLine($"Namn: {fordon.Typ}, Batteri: {fordon.Batteri}, Station: {fordon.Station}");
        }
        Console.WriteLine();
        Meny(); //Return menyn.
    }
    
    public static void SystemadminMeny() 
    {
        Console.Title = "Inloggat läge Systemadministratör";
        Console.ForegroundColor = ConsoleColor.DarkYellow; // BYTER FÄRG PÅ CONSOLE!!! WOOOOOO
        bool giltigtval = true; // Loop kontroll-värde
        while (giltigtval)
        {
            Console.WriteLine();
            Console.WriteLine("Välkommen till Ride & Glide Electrics!");
            Console.WriteLine("1. Visa stationer");
            Console.WriteLine("2. Ändra stationer");
            Console.WriteLine("3. Visa fordon och dess status");
            Console.WriteLine("4. Ändra fordon");
            Console.WriteLine("5. Logga ut");
            Console.WriteLine("6. Avsluta applikationen");
            Console.Write("Ditt val?: ");
            string val = Console.ReadLine();
            switch (val) // Använder input för vilket switch case som ska användas.
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Cyan; // BYTER FÄRG PÅ CONSOLE!!! WOOOOOO
                    ShowStations(); // Kallar på metoden från Affärslager klassen. (här måste vi lägga till denna metod)
                    break;
                case "2":
                    ChangeStations(); // Kallar på metoden från Affärslager klassen. (här måste vi lägga till denna metod)
                    break;
                case "3":
                    VisaFordonStatus(); // Kallar på metoden från Affärslager klassen. (här måste vi lägga till denna metod)
                    break;
                case "4":
                    ChangeVehicleStatus(); // Kallar på metoden från Affärslager klassen. (här måste vi lägga till denna metod)
                    break;
                case "5":
                    Logout(); //Kallar på metod för utloggning.
                    break;
                case "6":
                    Environment.Exit(0); //Avlutar allt.
                    break;
            }
        }
    * // utkomenterad consoll kod

        public static void ShowStations() //Metod för att visa befintliga stationer
        {

        }

        public static void ChangeStations() //Metod för att ändra befintliga stationer, till exempel vid utökad kapacitet, dock out of scope!
        {

        }

        public static void VisaFordonStatus() //Metod för att hämta information om Fordons status
        {

        }

        public static void ChangeVehicleStatus() //Metod för att ändra på fordons status, tex om fordon måste plockas bort pga service, eller om de laddas.
        {

        }
        private static void Logout() //Metod för utloggning.
        {
            Behörighetsgradinloggad = 0;
            Login(); //Återkommer till inloggningssidan.
        }
    }
  /*  public class Betalning //egentligen out of scope men behöver ändå vara med för att visa att vi kontrollerar mot giltig betalningsmetod när vi gör hyrprocessen.
    {
        public static void VisaBetalningsmetod((string betalningsmetod, string kortnummer = null, DateTime? giltighetstid = null) //Metod för att återhämta information om betalningsmetod från Registrering.
        {

            if (betalningsmetod.Equals("Autogiro", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Betalningsmetod: Autogiro");
            }
            else if (betalningsmetod.Equals("Faktura", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Betalningsmetod: Faktura");
            }
            else if (betalningsmetod.Equals("Kort", StringComparison.OrdinalIgnoreCase))
            {
                if (!string.IsNullOrEmpty(kortnummer) && giltighetstid.HasValue)
                {
                    if (ÄrKortnummerGiltigt(kortnummer) && ÄrGiltighetstidGiltig(giltighetstid.Value))
                    {
                        Console.WriteLine("Kortnummer och giltighetstid är giltiga.");
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt kortnummer eller giltighetstid.");
                    }
                }
                else
                {
                    Console.WriteLine("Kortnummer eller giltighetstid saknas.");
                }
            }
            else
            {
                Console.WriteLine("Ogiltig betalningsmetod.");
            }
        }// mera utkomenterad konsoll kod

        // Metod för att kontrollera om kortnumret är giltigt med Luhn-algoritmen

        private bool ÄrKortnummerGiltigt(string kortnummer)
        {
            int summa = 0;
            bool dubblat = false;
            // Traversera kortnumret bakifrån
            for (int i = kortnummer.Length - 1; i >= 0; i--)
            {
                int siffra = int.Parse(kortnummer[i].ToString());

                if (dubblat)
                {
                    siffra *= 2;
                    if (siffra > 9)
                    {
                        siffra -= 9;
                    }
                }

                summa += siffra;
                dubblat = !dubblat;
            }

            // Kortnumret är giltigt om summan är delbar med 10
            return (summa % 10) == 0;
        }

        // Metod för att kontrollera om giltighetstiden är framåt i tiden
        private bool ÄrGiltighetstidGiltig(DateTime giltighetstid)
        {
            // Kolla om kortet har gått ut
            return giltighetstid > DateTime.Now;
        }
    }

}*/

