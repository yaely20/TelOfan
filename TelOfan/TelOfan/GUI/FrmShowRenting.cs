using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelOfan.BLL;

namespace TelOfan.GUI
{
    public partial class FrmShowRenting : Form
    {
        public FrmShowRenting()
        {
            InitializeComponent();
            dataGridView1.DataSource = MyDB.Renting.GetList().Where(x => x.CodeSubscription == ThisSubscription.subscription.NumID).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
