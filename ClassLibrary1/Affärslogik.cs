using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicelager
{
    public class FordonService
    {
        private readonly FordonRepository _fordonRepo;
        private readonly UthyrningsDataRepository _uthyrningsRepo;

        public FordonService(FordonRepository fordonRepo, UthyrningsDataRepository uthyrningsRepo)
        {
            _fordonRepo = fordonRepo;
            _uthyrningsRepo = uthyrningsRepo;
        }


        public bool BokaFordon(int fordonID, DateTime startTid, DateTime slutTid, int prisPerMinut)
        {
            // Hämta fordonet
            var fordon = _fordonRepo.GetFordonById(fordonID);
            if (fordon == null || fordon.Status != "Ledig")
            {
                // Fordonet är inte tillgängligt
                return false;
            }

            // Skapa uthyrningsdata
            var uthyrningData = new UthyrningsData(startTid, slutTid, fordonID, prisPerMinut);

            // Lägg till uthyrningen
            _uthyrningsRepo.AddUthyrningsData(uthyrningData);

            // Uppdatera fordonsstatus till uthyrd
            fordon.Status = "Uthyrd";
            FordonRepository.UpdateFordon(fordon);

            return true;
        }
    }

}
