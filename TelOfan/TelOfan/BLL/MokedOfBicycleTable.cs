using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
    public class MokedOfBicycleTable : GeneralTable
    {
        public MokedOfBicycleTable():base("MokedOfBicycle")
        {

            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new MokedOfBicycle(item));
            }
        }
        public List<MokedOfBicycle> GetList()

        {

            return base.list.ConvertAll(x => (MokedOfBicycle)x);
        }
    }
   
}
