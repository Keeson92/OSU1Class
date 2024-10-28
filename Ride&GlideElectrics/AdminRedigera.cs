using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ride_GlideElectrics;
using Servicelager;
using BusinessEntities;

namespace Ride_GlideElectrics
{
    public class AdminRedigera : Form
    {
        private Fordon _selectedFordon;

        public AdminRedigera(Fordon selectedFordon)
        {
            _selectedFordon = selectedFordon;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Initialization code here
        }
    }
}
