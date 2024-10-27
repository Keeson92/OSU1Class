using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicelager;
using BusinessEntities;

namespace Ride_GlideElectrics
{
    public partial class RedigeraFordon : Form
    {
        public RedigeraFordon()
        {
            InitializeComponent();
        }

        private void btn_Tillbaka_click(object sender, EventArgs e)
        {
           
          HuvudFönster HuvudFönster = new HuvudFönster(); // Skapar en instans av inloggningsfönstret
          HuvudFönster.Show(); // Öppnar det nya fönstret
          this.Close(); // Stänger det aktuella fönstret
        }
            private void btn_Redigera_click(object sender, EventArgs e)
        {
            HuvudFönster HuvudFönster = new HuvudFönster(); // Skapar en instans av inloggningsfönstret
            HuvudFönster.Show(); // Öppnar det nya fönstret
            this.Close(); // Stänger det aktuella fönstret
        }






    }
}
