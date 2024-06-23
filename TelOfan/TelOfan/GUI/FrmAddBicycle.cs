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
    public partial class FrmAddBicycle : Form
    {
        Bicycle b;
        FormStatus f;
        public FrmAddBicycle()
        {
            InitializeComponent();
            b = new Bicycle();
            this.Text = "הכנסת אופניים חדשות";
            f = FormStatus.add;
        }
        public FrmAddBicycle(Bicycle b)
        {
            InitializeComponent();
            this.b = b;
            this.Text = "עדכון פרטי האופניים";

            cmbPlace.Text = b.CompanyName;
            numericUpDown1.Value = b.SizeBicycle;
            txtCode.Text = b.LockCode.ToString();
            txtNumHour.Text = b.HourlyRate.ToString();
            f = FormStatus.update;
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            if (f == FormStatus.add)
            {
                int code = MyDB.Bicycle.GetList().Max(x => x.Code) + 1;//למה הקוד לא עובד??
                MessageBox.Show(code.ToString());
                b.Code = code;
                b.CompanyName = cmbPlace.SelectedItem.ToString();
                b.SizeBicycle = Convert.ToInt32(numericUpDown1.Value);
                b.LockCode = Convert.ToInt32(txtCode.Text);
                b.HourlyRate = Convert.ToInt32(txtNumHour.Text);
                b.Status = true;
                MyDB.Bicycle.AddItem(b);
                MyDB.Bicycle.SaveChanges();
                MessageBox.Show("האופניים נוספו בהצלחה");
                this.Hide();
            }
            else
            {
                b.CompanyName = cmbPlace.SelectedItem.ToString();
                b.SizeBicycle = Convert.ToInt32(numericUpDown1.Value);
                b.LockCode = Convert.ToInt32(txtCode.Text);
                b.HourlyRate = Convert.ToInt32(txtNumHour.Text);
                b.Status = true;
                MyDB.Bicycle.UpdateItem(b);
                MyDB.Bicycle.SaveChanges();
                MessageBox.Show("השינויים נשמרו בהצלחה");
                this.Hide();
            }
        }

    }
}
