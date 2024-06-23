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
    public partial class FrmPayment : Form
    {
        Subscription s;
        public FrmPayment()
        {
            InitializeComponent();
         
        }
        public FrmPayment(Subscription s)
        {
            InitializeComponent();
             s = new Subscription();
            this.s  = s;
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double x =( s.Debt) - Convert.ToDouble(txtprice.Text);
            s.Debt = x;
           
            MessageBox.Show(" השינוי בוצע בהצלחה");

        }
    }
}
