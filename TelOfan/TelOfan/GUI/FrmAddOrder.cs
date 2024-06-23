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
    public partial class FrmAddOrder : Form
    {
        
      
        public FrmAddOrder()
        {
            InitializeComponent();

            lblSubs.Text = ThisSubscription.subscription.ToString();
            lblBis.Text = ThisSubscription.bicycle.ToString();
            txtprice.Text = ThisSubscription.bicycle.HourlyRate.ToString();
        }

       

        private void FrmAddOrder_Load(object sender, EventArgs e)
        {

        }

        private void timeEnd_ValueChanged(object sender, EventArgs e)
        {
            calcTime();
        }

        private void calcTime()
        {
            TimeSpan hours1 = ((TimeSpan)(timeEnd.Value - timeStart.Value)) ;
            int hours = Convert.ToInt32(hours1.TotalHours);// timeEnd.Value.Hour - timeStart.Value.Hour;
            if (timeEnd.Value.Minute > timeStart.Value.Minute)
            {
                hours++;
            }
            TxtCount.Text = hours.ToString();

            txtSum.Text = (hours * ThisSubscription.bicycle.HourlyRate).ToString();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            addOrder();
        }

        private void addOrder()
        {///חישוב שעות 
            calcTime();
            //הוספת הזמנה 
            int code = MyDB.Renting.GetList().Max(m => m.Code);
            Renting r = new Renting();

            r.Code = code + 1;
            r.CodeSubscription = ThisSubscription.subscription.NumID;
            r.CodeMokedBicycle = MyDB.MokedOfBicycle.GetList().Where(x => x.CodeBicycle == ThisSubscription.bicycle.Code).First().CodeMoked;
            r.TimeOfTaking = timeStart.Value;
            r.ReturnTime = timeEnd.Value;
            r.TotaPayment = Convert.ToInt32(txtSum.Text);
            MyDB.Renting.AddItem(r);
            MyDB.Renting.SaveChanges();
            ///עדכון חוב
            ThisSubscription.subscription.Debt += Convert.ToInt32(txtSum.Text); ;
            MyDB.Subscription.UpdateItem(ThisSubscription.subscription);
            MyDB.Subscription.SaveChanges();
            ///עדכון אופנים תפוסות
            ThisSubscription.bicycle.Status = true;
            MyDB.Bicycle.UpdateItem(ThisSubscription.bicycle);
            MyDB.Bicycle.SaveChanges();
            MessageBox.Show(" ההזמנה בוצעה בהצלחה" ); 

        }
    }
}
