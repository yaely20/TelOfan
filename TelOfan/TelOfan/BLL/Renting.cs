using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
      public   class Renting:GeneralRow
    {
        public int Code { get; set; }
        public string CodeSubscription { get; set; }
        public int CodeMokedBicycle { get; set; }
        public DateTime TimeOfTaking { get; set; }
        public DateTime ReturnTime { get; set; }
        public int TotaPayment { get; set; }
        public Renting() : base()
        {
        }

        public Renting(DataRow row) : base(row)
        {
        }
        public override void FillDataRow()

        {
            row["Code"] = this.Code;
            row["CodeSubscription"] = this.CodeSubscription;
            row["CodeMokedBicycle"] = this.CodeMokedBicycle;
            row["TimeOfTaking"] = this.TimeOfTaking;
            row["ReturnTime"] = this.ReturnTime;
            row["TotaPayment"] = this.TotaPayment;
        }
        public override void FillFields()

        {

            this.Code = Convert.ToInt32(row["Code"]);
            this.CodeSubscription = row["CodeSubscription"].ToString();
            this.CodeMokedBicycle = Convert.ToInt32(row["CodeMokedBicycle"]);
            this.TimeOfTaking = Convert.ToDateTime(row["TimeOfTaking"]);
            this.ReturnTime = Convert.ToDateTime(row["ReturnTime"]);
            this.TotaPayment = Convert.ToInt32(row["TotaPayment"]);
        }
        public override string ToString()

        {

            return "קוד : " + Code + " קוד מנוי: " + CodeSubscription+"קוד אופניים במוקד"+ CodeMokedBicycle+"שעת לקיחה"+ TimeOfTaking+"שעת החזרה"+ ReturnTime+"סהכ לתשלום"+ TotaPayment;
        }




















    }
}
