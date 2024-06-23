using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
      public  class Workers:GeneralRow
    {
        public string NumID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Workers() : base()
        {
        }

        public Workers(DataRow row) : base(row)
        {
        }
        public override void FillDataRow()

        {
            row["NumID"] = this.NumID;
            row["LastName"] = this.LastName;
            row["FirstName"] = this.FirstName;
            row["StartDate"] = this.StartDate;
            row["DateOfBirth"] = this.DateOfBirth;
        }
        public override void FillFields()

        {
            this.NumID = row["NumID"].ToString();
            this.LastName = row["LastName"].ToString();
            this.FirstName = row["FirstName"].ToString();
            this.StartDate = Convert.ToDateTime(row["StartDate"]);
            this.DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
        }
        public override string ToString()

        {

            return "ת.ז : " + NumID + " שם פרטי: " + LastName + "שם משפחה" + FirstName + "תאריך תחילת העבודה" + StartDate + "תאריך לידה" + DateOfBirth;
        }
    }
}
