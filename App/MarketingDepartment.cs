using System.Collections.Generic;
using del_exp.App.models;
using del_exp.App.Services;

namespace del_exp.App
{
    public delegate bool DoAfterGetAddresses(List<CustomerAddress> ListOfAddresses);
    public class MarketingDepartment
    {
        public bool ExecuteMareketingPlan(decimal budget)
        {
            bool result = false;
            AddressProvider MyAddressProvider = new AddressProvider();
            DoAfterGetAddresses ToDoAfterAddresses;

            if (budget < 10000)
            {
                PenCompany MyBallpenCompany = new PenCompany();
                ToDoAfterAddresses = MyBallpenCompany.SendPens;
            }
            else
            {
                CoffeeCupCompany MyCoffeeCupCompany = new CoffeeCupCompany();
                ToDoAfterAddresses = MyCoffeeCupCompany.SendCoffeCups;
            }
            
            result = MyAddressProvider.HandleCampaign(ToDoAfterAddresses);
            return result;
        }
    }
}