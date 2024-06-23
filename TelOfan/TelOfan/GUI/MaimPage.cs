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
    public partial class MaimPage : Form
    {
        bool flag = true;
        Moked m;
        Workers w;

        public MaimPage()
        {
            InitializeComponent();
            //s = new Subscription();
            m = new Moked();
            //d = null;
            w = new Workers();
            cmbMoked.DataSource = MyDB.Moked.GetList().Select(x => x.ThisCity + " רחוב:" + x.Street + " מספר:" + x.HouseNumber).ToList();

            cmbMoked.SelectedItem = null;
        }


        private void btnworker_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            Txid.Visible = true;
            BtOk.Visible = true;

        }

        private void btnsubscription_Click(object sender, EventArgs e)
        {


            label1.Visible = true;
            label2.Visible = true;
            cmbMoked.Visible = true;
            txtid.Visible = true;
            BtnOK.Visible = true;
        }


        private void BtnOK_Click(object sender, EventArgs e)
        {
            Subscription s;
            Subscription d;
            errorProvider1.Clear();
            //txtid.Text = "";
             flag = true;
            try { s = MyDB.Subscription.GetList().FirstOrDefault(x => x.NumID == txtid.Text); }

            catch
            {
                errorProvider1.SetError(txtid, "ת.ז. אינה תקינה");
                flag = false;
            }
            //לסדר את זה שהבחירה של הקומבובוקס לא תיהיה לפי האינדקס שנבחר ושיהיה קשור לקוד
            m = MyDB.Moked.GetList().FirstOrDefault(x => x.Code == (cmbMoked.SelectedIndex + 1));
            d = MyDB.Subscription.GetList().First(x => x.NumID == txtid.Text);


            if (flag)
            {
                ThisSubscription.subscription = d;
                FrmSubscription fs = new FrmSubscription(m);
                fs.Show();
                this.Hide();
            }
        }



        private void BtOk_Click(object sender, EventArgs e)
        {
        }
           
        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaimPage_Load(object sender, EventArgs e)
        {

        }

        private void BtOk_Click_1(object sender, EventArgs e)
        {
                errorProvider1.Clear();
                flag = true;


                //try { w = MyDB.Workers.GetList().FirstOrDefault(x => x.NumID == Txid.Text); }

                //catch
                {

                    w = MyDB.Workers.GetList().FirstOrDefault(x => x.NumID == Txid.Text);

                    if (!Validetion.CheckId(Txid.Text))
                    {
                        errorProvider1.SetError(Txid, "ת .ז אינה תקינה נסה שוב ");

                        flag = false;
                    }
                    else

                       if (w == null)
                    {
                        errorProvider1.SetError(Txid, "מופיע במערכתאתה לא ");
                        flag = false;
                    }
                    if (w != null)
                    {
                        FrmWorkers fw = new FrmWorkers();

                        this.Hide();
                        fw.ShowDialog();
                        fw.Show();
                    }




                }
                //if (flag)
                //{
                //    FrmWorkers fw = new FrmWorkers();

                //    this.Hide();
                //    fw.ShowDialog();
                //    fw.Show();

                //}

            }

        }
    }
