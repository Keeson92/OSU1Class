using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class UthyrningsData // se över metod i affärslager för HyraFordon() som sedan bildar textfil som återhämtas i metoden HyrHistorik..
    {
        public DateTime StartTid { get; private set; }
        public DateTime SlutTid { get; private set; }

        public int FordonsID { get; set; }

        public int PrisPerMinut { get; private set; }
        public UthyrningsData(DateTime startTid, DateTime slutTid, int fordonsID, int prisPerMinut) //Konstruktor för UthyrningsData
        {
            StartTid = startTid;
            SlutTid = slutTid;
            FordonsID = fordonsID;
            PrisPerMinut = prisPerMinut;
        }
    }

}
