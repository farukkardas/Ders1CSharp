using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AppealManager
    {
        public void Appeal(ICreditBaseManager creditBase,ILoggerService loggerService)
        {
            creditBase.Calculate();
            loggerService.Log();
        }

        public void CreditPreInfo(List<ICreditBaseManager> credits)
        {
            foreach (var xBaseManager in credits)
            {
                xBaseManager.Calculate();
            }
                         
            
        }
    }
}
