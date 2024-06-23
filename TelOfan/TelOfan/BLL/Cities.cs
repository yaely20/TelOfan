using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelOfan.BLL;
using System.Data;

namespace TelOfan.BLL
{
     public   class Cities : GeneralRow
    {
        public int Code { get; set; }
        public string NameCity { get; set; }
        public Cities () : base()
        {
        }

        public Cities(DataRow row) : base(row)
        {
        }
        public override void FillDataRow()

        {

            row["Code"] = this.Code;

            row["NameCity"] = this.NameCity;
        }
        public override void FillFields()

        {

            this.Code = Convert.ToInt32(row["Code"]);

            this.NameCity = row["NameCity"].ToString();

        }

        public override string ToString()

        {

            return "קוד העיר: " + Code + " שם העיר: " + NameCity;
            }
}
}
