using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ride_GlideElectrics
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            HuvudFönster frm = new(); // gå tillbaka till inloggning
            frm.Show(); // öppna inloggningsfönster
        }

        private void label2_Click(object sender, EventArgs e)
        {
            RedigeraFordon frm = new(); // här vill vi även ha med villket fordon vi redigerar ifrån föregånede form när det är redo
            frm.Show();
        }
    }
}
