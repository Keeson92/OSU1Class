using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibrary1
{
    // Data Access Layer (Repositories/ProgramRepository.cs)
    // Domain Layer (Entities/ProgramData.cs)
  

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