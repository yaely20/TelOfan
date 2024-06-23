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
    public partial class FrmShowBicycle : Form
    {
        public FrmShowBicycle()
        {
            InitializeComponent();
            dataGridView1.DataSource = MyDB.Bicycle.GetList().Where(x => x.Status == false).ToList();
        }
        private void btnDelite_Click(object sender, EventArgs e)
        {
            Bicycle b = MyDB.Bicycle.GetList().FirstOrDefault(x => x.Code == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            DialogResult r = MessageBox.Show("האים אתה בטוח שברצונך למחוק את אופן זה?", "מחיקת אופניים מהמאגר", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r==DialogResult.Yes)
            {
                MyDB.Bicycle.DeliteItem(b);
                MyDB.Bicycle.SaveChanges();
                dataGridView1.DataSource = MyDB.Bicycle.GetList().Where(x => x.Status == false).ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddBicycle fab = new FrmAddBicycle();
            this.Hide();
            fab.ShowDialog();
            this.Show();
            dataGridView1.DataSource = MyDB.Bicycle.GetList().Where(x => x.Status == false).ToList();
        }

        private void btnApdate_Click(object sender, EventArgs e)
        {
            Bicycle b = MyDB.Bicycle.GetList().FirstOrDefault(x => x.Code == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            FrmAddBicycle fab = new FrmAddBicycle(b);
            this.Hide();
            fab.ShowDialog();
            this.Show();
            dataGridView1.DataSource = MyDB.Bicycle.GetList().Where(x => x.Status == false).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmShowBicycle_Load(object sender, EventArgs e)
        {

        }
    }
}
