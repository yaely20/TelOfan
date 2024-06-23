using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
     public  class Moked : GeneralRow
    {
        public int Code { get; set; }
        public int City { get; set; }
        public string Street { get; set; }
         public int HouseNumber { get; set; }
        public string DescriptionOfThePlaceOfTheBicycle { get; set; }
        public Moked() : base()
        {
        }

        public Moked (DataRow row) : base (row)
        {
        }
        public override void FillDataRow()

        {

            row["Code"] = this.Code;
            row["City"] = this.City;
            row["Street"] = this.Street;
            row["HouseNumber"] = this.HouseNumber;
            row["DescriptionOfThePlaceOfTheBicycle"] = this.DescriptionOfThePlaceOfTheBicycle;
        }
        public override void FillFields()

        {

            this.Code = Convert.ToInt32(row["Code"]);
            this.City = Convert.ToInt32(row["City"]);
            this.Street = row["Street"].ToString();
            this.HouseNumber = Convert.ToInt32(row["HouseNumber"]);
            this.DescriptionOfThePlaceOfTheBicycle = row["DescriptionOfThePlaceOfTheBicycle"].ToString();

        }
        public override string ToString()

        {

            return "קוד המוקד: " + Code + " מספר העיר: " + City+"רחוב"+ Street + " מספר בית "+ HouseNumber+"תאור המקום"+ DescriptionOfThePlaceOfTheBicycle;
        }
        public Cities ThisCity
        {
            get { return MyDB.Cities.GetList().FirstOrDefault(x => x.Code == this.Code); }
        }
    }
}
