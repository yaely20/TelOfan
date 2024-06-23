using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
    public   class WorkersTable:GeneralTable
    {
        public WorkersTable():base("Workers")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Workers(item));
            }
        }
        public List<Workers> GetList()

        {

            return base.list.ConvertAll(x => (Workers)x);
        }
    }
    
}
