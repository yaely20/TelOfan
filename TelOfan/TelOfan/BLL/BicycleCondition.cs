using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
      public    class BicyleCondition : GeneralRow
    {
     
        
            public int Code { get; set; }
            public int CodeBicycle { get; set; }
             public int StatusCode { get; set; }
           public DateTime UpdateDate { get; set; }
           public DateTime UpdateHour { get; set; }

        public BicyleCondition() : base()
            {
            }

            public BicyleCondition(DataRow row) : base(row)
            {
            }
            public override void FillDataRow()

            {

                row["Code"] = this.Code;

                row["CodeBicycle "] = this.CodeBicycle;
                 row["StatusCode "] = this.StatusCode;
                row["UpdateDate "] = this.UpdateDate;
                row["UpdateHour "] = this.UpdateHour;
        }
            public override void FillFields()

            {

                this.Code = Convert.ToInt32(row["Code"]);

                this.CodeBicycle = Convert.ToInt32 (row["CodeBicycle"]);
               this.StatusCode = Convert.ToInt32(row["StatusCode"]);
            this.UpdateDate = Convert.ToDateTime(row["UpdateDate"]);
            this.UpdateHour = Convert.ToDateTime(row["UpdateHour"]);

        }

            public override string ToString()

            {

                return "קוד תאור: " + Code + " קוד אופניים: " + CodeBicycle+"קוד מצב"  + StatusCode+"תאריך עדכון"+ UpdateDate+"שעת עדכון"+ UpdateHour;
            }
        }
}
