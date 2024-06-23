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
    public partial class FrmShowAllDebts : Form
    {
        public FrmShowAllDebts()
        {
            InitializeComponent();
            dataGridView1.DataSource = MyDB.Subscription.GetList().Where(x => x.Debt >=0).ToList();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           Subscription s = MyDB.Subscription.GetList().FirstOrDefault(x => x.NumID == (dataGridView1.CurrentRow.Cells[0].Value).ToString());
           FrmPayment fp = new FrmPayment(s);
            this.Hide();
            fp.ShowDialog();
            this.Show();
        }
    }
}
