using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumerCreditManager consumerCreditManager = new ConsumerCreditManager();
            VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(consumerCreditManager, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() { consumerCreditManager , vehicleCreditManager};

            //applicationManager.CreditPreInfo(credits);
        }
    }
}
