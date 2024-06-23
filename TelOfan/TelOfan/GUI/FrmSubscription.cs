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
    public partial class FrmSubscription : Form
    {
        Moked thism;
      
        public FrmSubscription()
        {
            InitializeComponent();
        }
        public FrmSubscription(Moked m)
        {
            InitializeComponent();
            thism = m;
       
        }
        
      



        //הצגת אופניים
        private void button3_Click(object sender, EventArgs e)
        {
            FrmShowRenting fsr = new FrmShowRenting();

            this.Hide();
            fsr.ShowDialog();
            this.Show();
        }

        private void Renting_Click(object sender, EventArgs e)
        {
            FrmRenting fr = new FrmRenting(thism);

            this.Hide();
            fr.ShowDialog();
            this.Show();
        }
    }
}
