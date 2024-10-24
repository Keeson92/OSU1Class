using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibrary1
{
    // Data Access Layer (Repositories/ProgramRepository.cs)
    // Domain Layer (Entities/ProgramData.cs)
    public class StationData //Definierar vilken data som finns kring de olika programmen, om man tex skulle behöva lägga till/ta bort ett program.
    {
        public int Station {  get; private set; }
        public string Adress { get; private set; }
        public int AntalFordon { get; private set; } 
        public string FordonStatus { get; private set; }
        public int MaxKapacitet { get; private set; }

        public StationData(int station, string adress, int antalFordon, string fordonStatus, int maxKapacitet)
        {
            Station = station;
            Adress = adress;
            AntalFordon = antalFordon;
            FordonStatus = fordonStatus;
            MaxKapacitet = maxKapacitet;
        }
        public bool FinnsPlats()
        {
            return AntalFordon < MaxKapacitet;
        }

    }
    public class FordonData //Definierar vilken data som finns kring de olika Lokalerna, om man tex skulle behöva lägga till/ta bort en Lokal.
    {
        public int FordonsID { get; private set; }
        public int Batterinivå { get; private set; }
        public string Status { get; private set; }
        public string FordonsTyp { get; private set; }
        public FordonData(int fordonsID, int batterinivå, string status, string fordonsTyp)
        {
            FordonsID = fordonsID;
            Batterinivå = batterinivå;
            Status = status;
            FordonsTyp = fordonsTyp;
        }
    }
    public class AnvandareData //Definierar vilken data som finns kring Användare, om man tex skulle behöva lägga till/ta bort en Användare.
    {
        public int AnvandarID { get; }
        public string Fornamn { get; }
        public string Efternamn { get; }
        public int Personnummer { get; }
        public long Telefonnr { get; }
        public string Epost { get; }
        public string Password { get; }

        public int Behorighetsgrad { get; }
        public AnvandareData(int anvandarID, string fornamn, string efternamn, int personnummer, long telefonnr, string epost, string password, int behorighetsgrad)
        {
            AnvandarID = anvandarID;
            Fornamn = fornamn;
            Efternamn = efternamn;
            Personnummer = personnummer;
            Telefonnr = telefonnr;
            Epost = epost;
            Password = password;
            Behorighetsgrad = behorighetsgrad;
        }
    }
    public class KontoData //Definierar vilken data som finns kring behörighet, om man tex skulle behöva lägga till/ta bort behörighet eller på något vis förändra, tex lägga till bibliotekspersonal med egen behörighetsgrad.
    {
        public DateTime HyrHistorik { get; }
        public string BetalningsMetod { get; }
        public KontoData(DateTime hyrHistorik, string betalningsMetod)
        {
            HyrHistorik = hyrHistorik;
            BetalningsMetod = betalningsMetod;
        }
    }
    public class UthyrningsData // se över metod i affärslager för HyraFordon() som sedan bildar textfil som återhämtas i metoden HyrHistorik..
    {
        public DateTime StartTid { get; private set; } 
        public DateTime SlutTid { get; private set; }

        public int PrisPerMinut {  get; private set; }
        public UthyrningsData(DateTime startTid, DateTime slutTid, int prisPerMinut)
        {
            StartTid = startTid;
            SlutTid = slutTid;
            PrisPerMinut = prisPerMinut; 
        }
    }

}