using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
    public class Bicycle:GeneralRow
    {
        public int Code { get; set; }
        public string CompanyName { get; set; }
        public int SizeBicycle { get; set; }
        public int LockCode { get; set; }
        public int HourlyRate { get; set; }
        public bool Status { get; set; }

        public Bicycle () : base()
        {
        }
        public Bicycle (DataRow row) : base(row)
        {
        }
        public override void FillDataRow()

        {

            row["Code"] = this.Code;
            row["CompanyName"] = this.CompanyName;
            row["SizeBicycle"] = this.SizeBicycle;
            row["LockCode"] = this.LockCode;
            row["HourlyRate"] = this.HourlyRate;
            row["Status"] = this.Status;
        }
        public override void FillFields()

        {

            this.Code = Convert.ToInt32(row["Code"]);

            this.CompanyName = row["CompanyName"].ToString();

            this.SizeBicycle = Convert.ToInt32(row["SizeBicycle"]);


            this.LockCode = Convert.ToInt32(row["LockCode"]);

            this.HourlyRate = Convert.ToInt32(row["HourlyRate"]);

            this.Status = Convert.ToBoolean(row["Status"]);
        }
        public override string ToString()

        {

            return "קוד אופניים: " + Code + " שם המפעל: " + CompanyName + "מידת אופניים" + SizeBicycle +  "קוד מנעול" + LockCode + "תעריף לשעה " + HourlyRate;
        }
    }
}
