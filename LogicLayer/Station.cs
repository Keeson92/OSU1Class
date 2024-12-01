using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    
        public class StationData //Definierar vilken data som finns kring de olika stationerna, om man tex skulle behöva lägga till/ta bort en station.
        {
            public string Adress { get; private set; }
            public int AntalFordon { get; private set; }
            public string FordonStatus { get; private set; }
            public int MaxKapacitet { get; private set; }

            public StationData(string adress, int antalFordon, string fordonStatus, int maxKapacitet) //Konstruktor för StationData
            {
                Adress = adress;
                AntalFordon = antalFordon;
                FordonStatus = fordonStatus;
                MaxKapacitet = maxKapacitet;
            }
        public List<Fordon> FordonLista { get; private set; } = new List<Fordon>(); // En station har minst ett fordon kopplat till sig.

        public bool FinnsPlats()
            {
                return AntalFordon < MaxKapacitet;
            }
        }
}
