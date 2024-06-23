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
    public partial class FrmShowSub : Form
    {
        Subscription s;
        public FrmShowSub()
        {
            InitializeComponent();
            dataGridView1.DataSource = MyDB.Subscription.GetList();/*.Where(x => x.Status == false).ToList();*/
            s = new Subscription();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelite_Click(object sender, EventArgs e)
        {
             s = MyDB.Subscription.GetList().FirstOrDefault(x => x.NumID == (dataGridView1.CurrentRow.Cells[0].Value).ToString());
            DialogResult r = MessageBox.Show("האים אתה בטוח שברצונך למחוק את אופן זה?", "מחיקת אופניים מהמאגר", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                MyDB.Subscription.DeliteItem(s);
                MyDB.Subscription.SaveChanges();
                dataGridView1.DataSource = MyDB.Subscription.GetList();
            }
        }

        private void FrmShowSub_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
    }

