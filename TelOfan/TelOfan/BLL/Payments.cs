using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
      public  class Payments : GeneralRow
    {
        public int Code { get; set; }
       public int  SubscriptionCode { get; set; }
        public DateTime DateOfPaymant { get; set; }
        public int PaymentAmount { get; set; }
        public Payments() : base()
        {
        }

        public Payments(DataRow row) : base(row)
        {
        }
        public override void FillDataRow()

        {

            row["Code"] = this.Code;
            row["SubscriptionCode"] = this.SubscriptionCode;
            row["DateOfPaymant"] = this.DateOfPaymant;
            row["PaymentAmount"] = this.PaymentAmount;

        }
        public override void FillFields()

        {

            this.Code = Convert.ToInt32(row["Code"]);
            this.SubscriptionCode = Convert.ToInt32(row["SubscriptionCode"]);
            this.DateOfPaymant = Convert.ToDateTime(row["DateOfPaymant"]);
            this.PaymentAmount = Convert.ToInt32(row["PaymentAmount"]);
        }
        public override string ToString()

        {

            return "קוד : " + Code + " קוד מנוי: " + SubscriptionCode+"תאריך תשלום"+ DateOfPaymant+"סכום לתשלום"+ PaymentAmount;
        }


    }
    }
