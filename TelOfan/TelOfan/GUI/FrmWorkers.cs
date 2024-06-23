using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelOfan.GUI
{
    public partial class FrmWorkers : Form
    {
        public FrmWorkers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmShowBicycle fsb = new FrmShowBicycle();
            this.Hide();
            fsb.ShowDialog();
            this.Show();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            FrmShowSub fss = new FrmShowSub();
            this.Hide();
            fss.ShowDialog();
            this.Show();
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            FrmShowAllDebts fsad = new FrmShowAllDebts();
            this.Hide();
            fsad.ShowDialog();
            this.Show();
        }
    }
}
