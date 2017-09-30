using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestCustomerClientConsole
{
    class Program
    {
        /// <summary>
        /// Uge 39 på Peters Semesterplan: http://pele-easj.dk/2017e-tek/SEMESTER.html
        /// Link til opgaven: http://pele-easj.dk/2017e-tek/exercises/RestWCFService.docx
        /// </summary>

        private static string CustomersUri = "http://localhost:60422/CustomerService.svc/customers/";

        private static async Task<IList<Customer>> GetCustomersAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(CustomersUri);
                IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
                return cList;
            }
        }

        static void Main(string[] args)
        {
            var list = Task.Run(async () => await GetCustomersAsync());

            foreach (var cust in list.Result)
            {
                Console.WriteLine(cust);
            }
        }
    }
}
