using System;
using System.Collections.Generic;
using del_exp.App.models;

namespace del_exp.App.Services
{
    public class AddressProvider
    {
        public bool HandleCampaign(DoAfterGetAddresses ToDoAfterAddresses)
        {
            bool success = false;
            List<CustomerAddress> ListOfAddresses = GetAddressesNewProspects();
            success = ToDoAfterAddresses(ListOfAddresses); 
            Console.WriteLine("HandleCampaign!");
            return success;
        }
     
        private List<CustomerAddress> GetAddressesNewProspects()
        {
            return new List<CustomerAddress>();
        }
    }
}