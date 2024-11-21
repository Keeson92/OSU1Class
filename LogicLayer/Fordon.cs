using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace BusinessEntities
{
    
        public class Fordon //Definierar vilken data som finns kring de olika Lokalerna, om man tex skulle behöva lägga till/ta bort en Lokal.
        {
            public int FordonsID { get; private set; }
            public string Position { get; set; }
            public string Status { get; set; }
            public string FordonsTyp { get; set; }
        public StationData StationData { get; set; } // 0..1 - Ett fordon kan finnas på en station
        public List<UthyrningsData> Uthyrningar { get; set; } = new List<UthyrningsData>(); // 1..*

        // Konstruktor
        public Fordon(int fordonsID, string position, string status, string fordonsTyp)
        {
            FordonsID = fordonsID;
            Position = position;
            Status = status;
            FordonsTyp = fordonsTyp;
        }


        public override string ToString() //Returnerar en sträng med information om fordonet
        {
                return $"ID: {FordonsID}, Position: {Position}, Status: {Status}, Typ: {FordonsTyp}";
            }
        }

    
}
