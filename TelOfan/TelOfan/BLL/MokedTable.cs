using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TelOfan.BLL
{
      public class MokedTable : GeneralTable
    {

        public MokedTable() : base(" Moked")
        {


                foreach (DataRow item in base.table.Rows)
                {
                    list.Add(new Moked(item));
                }
            }
            public List<Moked> GetList()

            {

                return base.list.ConvertAll(x => (Moked)x);
            }

        }
    }
