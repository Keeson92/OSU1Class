using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessEnteties
{
    
        public class Fordon //Definierar vilken data som finns kring de olika Lokalerna, om man tex skulle behöva lägga till/ta bort en Lokal.
        {
            public int FordonsID { get; private set; }
            public string Position { get; private set; }
            public string Status { get; private set; }
            public string FordonsTyp { get; private set; }
            public Fordon(int fordonsID, string position, string status, string fordonsTyp)
            {
                FordonsID = fordonsID;
                Position = position;
                Status = status;
                FordonsTyp = fordonsTyp;
            }
        }
    
}
