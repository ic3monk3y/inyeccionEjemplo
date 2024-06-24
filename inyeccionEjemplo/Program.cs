using inyeccionEjemplo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inyeccionEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var customerService = new CustomerService();
            var communicationService = new CommunicationService();

            var customers = customerService.GetCustomers();

            var message = "Message to broadcast to all customers";


            foreach (var customer in customers)
            {
                communicationService.SendMessage(customer,message);
            }

            System.Threading.Thread.Sleep(5000);

        }
    }
}
