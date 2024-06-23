using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
    public class BicycleTable : GeneralTable
    {
        public BicycleTable() : base("Bicycle")
        {

            
                foreach (DataRow item in base.table.Rows)
                {
                    list.Add(new Bicycle(item));
                }
             }
            public List<Bicycle> GetList()

            {

                return base.list.ConvertAll(x => (Bicycle)x);
            }

        
    }

}
                  
            
             

  
