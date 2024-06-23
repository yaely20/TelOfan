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
    public partial class FrmRenting : Form
    {
        Moked thism;
      
        public FrmRenting()
        {
            InitializeComponent();
            
        }
        public FrmRenting(Moked m )
        {
            InitializeComponent();
            thism = m;
            //להציג את כל האופניים שנמצאות בטבלה של אופניים במוקד לפי קוד המוקד שנבחר
            //MessageBox.Show(thism.Code.ToString()); ;
           // List<MokedOfBicycle> bys =
              dataGridView1.DataSource = (from moked in MyDB.MokedOfBicycle.GetList().Where(x => x.CodeMoked == thism.Code).ToList()
                                          from b in MyDB.Bicycle.GetList().Where(t => t.Code == moked.CodeBicycle)
                                          where b.Status ==false
                                          select b).ToList();
                                       
                ;//.Select(x=>new { x.ThisBicycle.CompanyName, x.ThisBicycle.HourlyRate, x.ThisBicycle.LockCode, x.ThisBicycle.Size }).ToList();

            MessageBox.Show(dataGridView1.RowCount.ToString());
           
            label1.Text = "שלום ל " + ThisSubscription.subscription.NumID;

        }
     




        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {

            if(dataGridView1.SelectedRows.Count <0)
            {
                ////TODO:הוספת מסננת קלט לא נבחר אופנים 
                return;
            }
             
            Bicycle b = MyDB.Bicycle.GetList().Where(x => x.Code == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)).First();
            ThisSubscription.bicycle = b;
            FrmAddOrder fa = new FrmAddOrder();

            this.Hide();
           // fa.ShowDialog();
            fa.ShowDialog();

        }// int id = Convert.ToInt32(dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value);

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
