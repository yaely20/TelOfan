using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
   public class BicyleConditionTable : GeneralTable
    {
        public BicyleConditionTable(): base("BicyleCondition")
        
            {


                foreach (DataRow item in base.table.Rows)
                {
                    list.Add(new BicyleCondition(item));
                }
            }
            public List<BicyleCondition> GetList()

            {

                return base.list.ConvertAll(x => (BicyleCondition)x);
            }


        


    }
}
