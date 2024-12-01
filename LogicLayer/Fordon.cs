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

            public int BatteriNivå { get; set; }
            public string Status { get; set; }
            public string FordonsTyp { get; set; }
        [Browsable(false)] public StationData StationData { get; set; } // Ett fordon kan finnas på en station och Datagridview har ingen åtkomst till att visa den
        public List<UthyrningsHistorik> Uthyrningar { get; set; } = new List<UthyrningsHistorik>(); // Kopplar en till flera fordon till en lista på uthyrningar i UthyrningsHistorik Listan.

        // Konstruktor
        public Fordon(int fordonsID, string position, int batteriNivå, string status, string fordonsTyp)
        {
            FordonsID = fordonsID;
            Position = position;
            BatteriNivå = batteriNivå;
            Status = status;
            FordonsTyp = fordonsTyp;
        }


        public override string ToString() //Returnerar en sträng med information om fordonet
        {
                return $"ID: {FordonsID}, Position: {Position}, Status: {Status}, Typ: {FordonsTyp}";
            }
        }

    
}
