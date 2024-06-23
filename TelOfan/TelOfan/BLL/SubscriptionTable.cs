using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace TelOfan.BLL
{
    public class SubscriptionTable:GeneralTable

    {
        public SubscriptionTable():base("Subscription")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Subscription(item));
            }
        }
        public List<Subscription> GetList()

        {

            return base.list.ConvertAll(x => (Subscription)x);
        }
    }
    
}
