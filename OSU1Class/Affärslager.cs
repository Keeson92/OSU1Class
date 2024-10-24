using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Affärslager
    {
        public static void SkapaSchema()
        {
        DateTime dateTime = DateTime.MinValue; //Definierar datum för indata
        bool isValidDate = false;
        Console.ForegroundColor = ConsoleColor.DarkBlue; // BYTER FÄRG :D
            Console.WriteLine();
            while (!isValidDate)
            {
                Console.Write("Ange ett datum (YY:MM:DD): "); // Datum
                string date = Console.ReadLine();

                if (DateTime.TryParse(date, out dateTime)) // felhantering
                {
                    isValidDate = true;
                    Console.WriteLine($"Datumet är: {dateTime}");
                }
                else 
                {
                    Console.WriteLine("Ogiltigt datumformat. Försök igen.");
                }
            }
            Console.WriteLine();

TimeSpan startTime = TimeSpan.Zero; // nollvärde för starttid
TimeSpan endTime = TimeSpan.Zero; // nollvärde för slutid
Console.ForegroundColor = ConsoleColor.Green;

bool isValidTimeRange = false;

while (!isValidTimeRange)
{
    Console.Write("Ange ett tidintervall (t.ex. 10:00-12:00): ");
    string timerange = Console.ReadLine();//Input tidslinje


    string[] timeParts = timerange.Split('-');


    if (timeParts.Length == 2)
    {
        // Särskilljer intervallet
        if (TimeSpan.TryParse(timeParts[0], out startTime) && TimeSpan.TryParse(timeParts[1], out endTime))
        {
            // Felhantering startid < slutid och korekt format
            if (startTime <= endTime)
            {
                isValidTimeRange = true;
                Console.WriteLine($"Tidsintervallet är: {startTime} - {endTime}");
            }
            else
            {
                Console.WriteLine("Starttiden måste vara tidigare än sluttiden. Försök igen.");
            }
        }
        else
        {
            Console.WriteLine("Ogiltigt tidsformat. Försök igen.");
        }
    }
    else
    {
        Console.WriteLine("Ogiltigt tidsintervall. Använd formatet HH:MM-HH:MM.");
    }
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;

string Acronyme = ""; // Akronym som string
bool isValid = false;
while (!isValid)
{
    Console.Write("Kursakronym?: ");
    Acronyme = Console.ReadLine(); // input

    if (string.IsNullOrWhiteSpace(Acronyme)) // Diverse felhantering
    {
        Console.WriteLine("Indata kan ej vara tomt.");
    }
    else
    {
        Console.WriteLine($"Du skrev in: {Acronyme}");
        Console.WriteLine();
        break;
    }
}
Console.ForegroundColor = ConsoleColor.Yellow;

string Moment = ""; // moment värde
bool isMValid = false;
while (!isMValid)
{
    Console.Write("Moment?: ");
    Moment = Console.ReadLine(); // input

    if (string.IsNullOrWhiteSpace(Moment)) // Felhantering
    {
        Console.WriteLine("Felaktig indata, datan måste innehålla information.");
    }
    else
    {
        Console.WriteLine($"Du skrev in {Moment}");
        Console.WriteLine();
        break;
    }
    string RoomID = ""; // moment värde
    bool isRValid = false;
    while (!isRValid)
    {
        Console.Write("Villken Sal?: ");
        RoomID = Console.ReadLine(); // input

        if (string.IsNullOrWhiteSpace(RoomID)) // Felhantering
        {
            Console.WriteLine("Felaktig indata, datan måste innehålla information.");
        }
        else
        {
            Console.WriteLine($"Du skrev in {RoomID}");
            Console.WriteLine();
            break;
        }
        string Signature = ""; // moment värde
        bool isSValid = false;
        while (!isSValid)
        {
            Console.Write("Signatur?: ");
            Signature = Console.ReadLine(); // input

            if (string.IsNullOrWhiteSpace(Signature)) // Felhantering
            {
                Console.WriteLine("Felaktig indata, datan måste innehålla information.");
            }
            else
            {
                Console.WriteLine($"Du skrev in {Signature}");
                Console.WriteLine();
                break;
            }
        }
    }
}
