using Servicelager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentationslager
{
    public partial class Control : Form
    {
        private UthyrningsDataRepository _uthyrningsRepo;

        public Control()
        {
            InitializeComponent();
            _uthyrningsRepo = new UthyrningsDataRepository(); // Initialize the repository
            LoadUthyrningData(); // Load data when the form is initialized

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void LoadUthyrningData()
        {
            var uthyrningsList = _uthyrningsRepo.GetAllUthyrningsData();
            // Assuming you have a DataGridView to display this data
            dataGridView1.DataSource = uthyrningsList; // Bind the list to the DataGridView
        }

    }
}

