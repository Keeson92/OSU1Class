using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessEnteties
{
    
        public class StationData //Definierar vilken data som finns kring de olika programmen, om man tex skulle behöva lägga till/ta bort ett program.
        {
            public string Adress { get; private set; }
            public int AntalFordon { get; private set; }
            public string FordonStatus { get; private set; }
            public int MaxKapacitet { get; private set; }

            public StationData(string adress, int antalFordon, string fordonStatus, int maxKapacitet)
            {
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
}
