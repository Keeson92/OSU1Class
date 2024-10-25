﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnessEnteties
{
    
        public class Fordon //Definierar vilken data som finns kring de olika Lokalerna, om man tex skulle behöva lägga till/ta bort en Lokal.
        {
            public int FordonsID { get; private set; }
            public string position { get; private set; }
            public string Status { get; private set; }
            public string FordonsTyp { get; private set; }
            public Fordon(int fordonsID, string position, string status, string fordonsTyp)
            {
                FordonsID = fordonsID;
                position = position;
                Status = status;
                FordonsTyp = fordonsTyp;
            }
        }
    
}
