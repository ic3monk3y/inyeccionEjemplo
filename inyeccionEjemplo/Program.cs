using inyeccionEjemplo.Repositories;
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

            #region Dependencias
            var connection = new MySQLConnection();
            /*var connection = new OracleConnection();*/

            var repository = new CustomerRepository(connection);

            var sender = new EmailService();
            /*var sender = new SMSService();*/
            #endregion Dependencias

            var customerService = new CustomerService(repository);
            var communicationService = new CommunicationService(sender);

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
