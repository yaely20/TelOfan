using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
      public class RentingTable:GeneralTable
    {
        public RentingTable():base("Renting")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Renting(item));
            }
        }
        public List<Renting> GetList()

        {

            return base.list.ConvertAll(x => (Renting)x);
        }
    }
    
}
