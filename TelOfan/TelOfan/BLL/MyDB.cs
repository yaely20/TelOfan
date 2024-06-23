using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelOfan.BLL
{
    enum FormStatus { add,update};
    public static class MyDB
    {
        public static BicycleTable Bicycle = new BicycleTable();
        public static BicyleConditionTable BicyleCondition = new BicyleConditionTable();
        public static CitiesTable Cities = new CitiesTable();
        public static MokedOfBicycleTable MokedOfBicycle = new MokedOfBicycleTable();
        public static MokedTable Moked = new MokedTable();
        public static PaymentsTable Payments = new PaymentsTable();
        public static RentingTable Renting = new RentingTable();
        public static SubscriptionTable Subscription = new SubscriptionTable();
        public static WorkersTable Workers = new WorkersTable();
        
    }
}
