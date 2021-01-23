using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditBaseManager financeCredit = new FinanceCredit();
            ICreditBaseManager vehicleCredit = new VehicleCredit();
            ICreditBaseManager mortgage = new Mortgage();

            ILoggerService databeseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            AppealManager appealManager = new AppealManager();
            appealManager.Appeal(new ArtisanCredit(),new SmsLogger());

            List<ICreditBaseManager> credits = new List<ICreditBaseManager>() {financeCredit,vehicleCredit};

            //appealManager.CreditPreInfo(credits);
            
         
        }
    }
}
