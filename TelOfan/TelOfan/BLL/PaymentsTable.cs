using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
      public class PaymentsTable:GeneralTable
    {


        public PaymentsTable():  base("Payments")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Payments(item));
            }
        }


        public List<Payments> GetList()

        {

            return base.list.ConvertAll(x => (Payments)x);
        }
    }
    
}
