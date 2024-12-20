﻿using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicelager
{
    #region FordonService
    public class FordonService
    {
        private readonly FordonRepository _fordonRepo;
        private readonly UthyrningsHistorikRepository _uthyrningsRepo;

        public FordonService(FordonRepository fordonRepo, UthyrningsHistorikRepository uthyrningsRepo)
        {
            _fordonRepo = fordonRepo;
            _uthyrningsRepo = uthyrningsRepo;
        }


        public bool BokaFordon(User user, int fordonID, DateTime startTid, DateTime slutTid, int prisPerMinut)
        {
            // Hämta fordonet
            var fordon = _fordonRepo.GetFordonById(fordonID);
            if (fordon == null || fordon.Status != "Ledig")
            {
                // Fordonet är inte tillgängligt
                return false;
            }

            // Skapa uthyrningshistorik
            var uthyrninghistorik = new UthyrningsHistorik(user, startTid, slutTid, prisPerMinut, fordon);

            // Lägg till uthyrningen
            _uthyrningsRepo.AddUthyrningsHistorik(uthyrninghistorik);

            // Uppdatera fordonsstatus till uthyrd
            fordon.Status = "Uthyrd";
            FordonRepository.UpdateFordon(fordon);

            return true;
        }
        
    }
    #endregion

    #region AnvandareService
    public class AnvandareService
    {
        private readonly AnvandareRepository _repository;

        public AnvandareService()
        {
             _repository = new AnvandareRepository();
        }

        public bool Login(int UserID, string password, out User user)
        {
             // Använder repository för att söka efter användaren
             user = _repository.GetAllAnvandare(UserID, password);

             // Kontrollera om användaren hittades
             return user != null;
        }
    }
    #endregion
    
}
