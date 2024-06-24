using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inyeccionEjemplo.Services
{
    public class EmailService
    {
        public void Send(Customer customer, string message)
        {
            Console.WriteLine($"Message sent to {customer.name} by eamil");
        }
    }
}
