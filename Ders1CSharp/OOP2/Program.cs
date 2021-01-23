using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer realCustomer1 = new RealCustomer();
            realCustomer1.CustomerNumber = "12345";
            realCustomer1.FirstName = "Faruk";
            realCustomer1.LastName = "Kardaş";
            realCustomer1.TcNo = "154587412226";
            realCustomer1.Id = 2;

            CorporateCustomer corporateCustomer1 = new CorporateCustomer();
            corporateCustomer1.CompanyName = "Kardaş Holding";
            corporateCustomer1.TaxNumber = "15678915";
            corporateCustomer1.Id = 1;
            corporateCustomer1.CustomerNumber = "15645674";

            Customer customer1 = new RealCustomer();
            Customer customer2 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
