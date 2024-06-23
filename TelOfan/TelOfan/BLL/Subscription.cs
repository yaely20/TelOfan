using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
    public class Subscription : GeneralRow
    {
        public string NumID;
        public DateTime JoinDate { get; set; }

        public bool ActiveSubscription { get; set; }
        public int CodeCity { get; set; }
        public double Debt { get; set; }

        public Subscription() : base()
        {
        }

        public Subscription(DataRow row) : base(row)
        {
        }
        public override void FillDataRow()

        {
            row["NumID"] = this.NumID;
            row["JoinDate"] = this.JoinDate;
            row["ActiveSubscription"] = this.ActiveSubscription;
            row["CodeCity"] = this.CodeCity;
            row["Debt"] = this.Debt;
        }
        public override void FillFields()

        {
            this.NumID = row["NumID"].ToString();
            this.JoinDate = Convert.ToDateTime(row["JoinDate"]);
            this.ActiveSubscription = Convert.ToBoolean(row["ActiveSubscription"]);
            this.CodeCity = Convert.ToInt32(row["CodeCity"]);
            this.Debt = Convert.ToDouble(row["Debt"]);
        }
        public override string ToString()

        {

            return "ת.ז : " + NumID + "תאריך הצטרפות: " + JoinDate + "פעיל או לא?" + ActiveSubscription + "קוד עיר" + CodeCity + "חובות " + Debt;
        }
    }
    
    //public string NumID
    //{
    //    get { return numID; }
    //    set
    //    {
    //        if (Validetion.CheckId(value))
    //            numID = value;
    //        else
    //            throw new Exception("תעודת הזהות אינה תקינה ");
    //    }

    
}
