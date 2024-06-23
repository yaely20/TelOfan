using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
    public class CitiesTable:GeneralTable
    {
        public CitiesTable() : base("Cities")
        {
           
        


                foreach (DataRow item in base.table.Rows)
                {
                    list.Add(new Cities(item));
                }
            }
            public List<Cities> GetList()

            {

                return base.list.ConvertAll(x => (Cities)x);
            }

    }
}
