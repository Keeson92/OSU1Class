using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    
        public class Fordon //Definierar vilken data som finns kring de olika Lokalerna, om man tex skulle behöva lägga till/ta bort en Lokal.
        {
            public int FordonsID { get; private set; }
            public string Position { get; set; }
            public string Status { get; set; }
            public string FordonsTyp { get; set; }
            public Fordon(int fordonsID, string position, string status, string fordonsTyp)
            {
                FordonsID = fordonsID;
                Position = position;
                Status = status;
                FordonsTyp = fordonsTyp;
            }
            public override string ToString()
            {
                return $"ID: {FordonsID}, Position: {Position}, Status: {Status}, Typ: {FordonsTyp}";
            }
        }

    
}
