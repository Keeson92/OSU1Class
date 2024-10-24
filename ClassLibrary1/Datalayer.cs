﻿using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data     //Klasser = Behörighet, Anvandare, Lokal, Program, Kurs
{

        public class FordonRepository
        {
            private List<FordonData> _fordonLista;
            public FordonRepository()
            {
                // Initialiserar data
                _fordonLista = new List<FordonData>
                    {
                        new FordonData(1, 85, "Bokad", "Elcykel"),
                        new FordonData(2, 83, "Ledig", "Elsparkcykel"),
                        new FordonData(3, 10, "Laddas", "Elsparkcykel")
                    };
            }
            public List<FordonData> GetAllFordon() //Metod för att få alla behörigheter som finns.
            {
                return _fordonLista;
            }
        }


    public class AnvandareRepository
    {
        private List<AnvandareData> _anvandareLista;
        public AnvandareRepository()
        {
            // Initialiserar data
            _anvandareLista = new List<AnvandareData>
            {
                    new AnvandareData(1, "Alice", "Karlsson", 980101, 701234567, "alice.karlsson@gmail.com", "1"),
                    new AnvandareData(2, "Gustav", "Karlholm", 960101, 732345678, "gustav.karlholm@protonmail.com", "2"),
                    new AnvandareData(3, "Kajsa", "Josefsson", 960101, 763456789, "kajsa.josefsson@hb.com", "3"),
                    new AnvandareData(4, "Gideon", "Lindgren", 860101, 794567890, "gideon.lindgren@raceoffice.com", "4"),
                    new AnvandareData(5, "Johannes", "Pettersson", 430101, 705678901, "johannes.pettersson@hb.com", "5"),
                    new AnvandareData(6, "Yasmine", "Nilsson", 320606, 736789012, "yasmine.nilsson@gu.org", "6"),
                    new AnvandareData(7, "Rebecka", "Svensson", 040404, 767890123, "rebecka.svensson@chalmers.net", "7"),
                    new AnvandareData(8, "Filip", "Olsson", 060101, 798901234, "filip.olsson@havard.co", "8"),
                    new AnvandareData(9, "Millie", "Karlsson", 1010101, 709012345, "millie.karlsson@cambridge.edu", "9"),
                    new AnvandareData(10, "Dag", "Hansson", 010101, 730123456, "dag.hansson@enterprise.biz", "10"),
                    new AnvandareData(11, "Ia", "Persson", 001001, 761234567, "ia.persson@provider.io", "11")
            };
        }
        public List<AnvandareData> GetAllAnvandare() //Metod för att få alla Användare som finns.
        {
            return _anvandareLista;
        }
    }
    public class KontoRepository
    {
        private List<KontoData> _kontolista;
        public KontoRepository()
        {
            // Initialiserar data
             _kontolista = new List<KontoData>
             {
                        new KontoData(new DateTime(2024, 9, 24), "Mastercard"),
                        new KontoData(new DateTime(2024, 9, 24), "Visa"),
                        new KontoData(new DateTime(2024, 9, 24), "Mastercard"),
                        new KontoData(new DateTime(2024, 9, 24), "Revolut"),
                        new KontoData(new DateTime(2024, 9, 24), "American Express"),
                        new KontoData(new DateTime(2024, 9, 24), "Swish"),
                        new KontoData(new DateTime(2024, 9, 24), "Mastercard"),
                        new KontoData(new DateTime(2024, 9, 24), "Mastercard")
             };
        }
        public List<KontoData> GetAllKonto() //Metod för att få alla Lokaler som finns.
        {
                return _kontolista;
        }
    }
    public class StationRepository
    {
        private List<StationData> _stationList;
        public StationRepository()
        {
            // Initialiserar data
            _stationList = new List<StationData>
            {
                   new StationData("Allégatan", 10, "Tillänglig", 20),
                   new StationData("Stationsgatan", 5, "På Underhåll", 50),
                   new StationData("Fredriksbergsgatan", 8, "Fullbokat", 100),
                   new StationData("Solrosvägen", 12, "Tillgänglig", 25)
            };
        }
        public List<StationData> GetAllStationer() //Metod för att få alla stationer som finns.
        {
             return _stationList;
        }
    }
    public class UthyrningsDataRepository
    {
         private List<UthyrningsData> _uthyrningsdatalist;
         public UthyrningsDataRepository()
         {
            // Initialiserar data
             _uthyrningsdatalist = new List<UthyrningsData>
         {
                    new UthyrningsData(new DateTime(2024, 10, 22, 10, 30, 0), new DateTime(2024, 10, 22, 12, 30, 0), 5),
                    new UthyrningsData(new DateTime(2024, 10, 23, 9, 0, 0), new DateTime(2024, 10, 23, 11, 15, 0), 6),
                    new UthyrningsData(new DateTime(2024, 10, 24, 14, 0, 0), new DateTime(2024, 10, 24, 16, 0, 0), 7),
                    new UthyrningsData(new DateTime(2024, 10, 25, 8, 30, 0), new DateTime(2024, 10, 25, 10, 30, 0), 8),
                    new UthyrningsData(new DateTime(2024, 10, 26, 13, 15, 0), new DateTime(2024, 10, 26, 14, 45, 0), 4),
                    new UthyrningsData(new DateTime(2024, 10, 27, 11, 0, 0), new DateTime(2024, 10, 27, 12, 30, 0), 5)
             };
         }
         public List<UthyrningsData> GetAllUthyrningsData() //Metod för att få alla kurser som finns.
         {
                return _uthyrningsdatalist;
         }
    }
    public class KontoDataRepository
    {
         private List<KontoData> _kontoDatalist;

         public KontoDataRepository()
         {
              _kontoDatalist = new List<KontoData>
              {
                    new KontoData(new DateTime(2024, 10, 22), "Mastercard"),
                    new KontoData(new DateTime(2024, 10, 23), "Swish"),
                    new KontoData(new DateTime(2024, 10, 24), "Mastercard"),
                    new KontoData(new DateTime(2024, 10, 25), "Mastercard"),
                    new KontoData(new DateTime(2024, 10, 26), "Mastercard"),
              };
         }

         public List<KontoData> GetAllKontoData()
         {
              return _kontoDatalist;
         }


         public void AddKontoData(KontoData kontoData)
         {
                _kontoDatalist.Add(kontoData);
         }
         public KontoData GetKontoDataByDate(DateTime hyrHistorik)
         {
                return _kontoDatalist.FirstOrDefault(k => k.HyrHistorik == hyrHistorik);
         }
    }
}

    
        
           
