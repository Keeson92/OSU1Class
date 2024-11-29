using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            public int Batterinivå { get; set; }
            public string Status { get; set; }
            public string FordonsTyp { get; set; }
        [Browsable(false)] public StationData StationData { get; set; } // 0..1 - Ett fordon kan finnas på en station och Datagridview har ingen åtkomst till att visa den
        public List<UthyrningsData> Uthyrningar { get; set; } = new List<UthyrningsData>(); // 1..*

        // Konstruktor
        public Fordon(int fordonsID, string position, int batterinivå, string status, string fordonsTyp)
        {
            FordonsID = fordonsID;
            Position = position;
            Batterinivå = batterinivå;
            Status = status;
            FordonsTyp = fordonsTyp;
        }


        public override string ToString() //Returnerar en sträng med information om fordonet
        {
                return $"ID: {FordonsID}, Position: {Position}, Status: {Status}, Typ: {FordonsTyp}";
            }
        }

    
}
