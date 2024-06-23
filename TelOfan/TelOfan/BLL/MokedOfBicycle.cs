using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
      public  class MokedOfBicycle : GeneralRow
    {
        public int Code { get; set; }
        public int CodeBicycle { get; set; }
        public int CodeMoked { get; set; }
        public MokedOfBicycle() : base()
        {
        }

        public MokedOfBicycle(DataRow row) : base(row)
        {
        }
        public Bicycle ThisBicycle
        {
            get { return MyDB.Bicycle.GetList().FirstOrDefault(x => x.Code == this.CodeBicycle); }
        }
        public override void FillDataRow()

        {
            row["Code"] = this.Code;
            row["CodeBicycle"] = this.CodeBicycle;
            row["CodeMoked"] = this.CodeMoked;
        }
        public override void FillFields()

        {

            this.Code = Convert.ToInt32(row["Code"]);
            this.CodeBicycle = Convert.ToInt32(row["CodeBicycle"]);
            this.CodeMoked = Convert.ToInt32(row["CodeMoked"]);
        }
        public override string ToString()

        {

            return "קוד : " + Code + " קוד אופן " + CodeBicycle + "קוד מוקד" + CodeMoked;
        }
    }
}  
