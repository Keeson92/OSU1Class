﻿using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BusinessEntities

{
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

}