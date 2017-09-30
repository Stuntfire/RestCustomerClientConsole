using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestCustomerClientConsole
{
    /// <summary>
    /// Uge 39 på Peters Semesterplan: http://pele-easj.dk/2017e-tek/SEMESTER.html
    /// Link til opgaven: http://pele-easj.dk/2017e-tek/exercises/RestWCFService.docx
    /// </summary>
    public class Customer
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public int Year { get; set; }

        public Customer(int id, string first, string last, int year)
        {
            this.Id = id;
            this.FirstName = first;
            this.LastName = last;
            this.Year = year;
        }

        public Customer()
        {

        }

        //private static string CustomersUri = "http://localhost:60422/CustomerService.svc/customers/";

        //private static async Task<IList<Customer>> GetCustomersAsync()
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        string content = await client.GetStringAsync(CustomersUri);
        //        IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
        //        return cList;
        //    }
        //}

        //public void Start()
        //{
        //    var list = Task.Run(async () => await GetCustomersAsync());

        //    foreach (var cust in list.Result)
        //    {
        //        Console.WriteLine(cust);
        //    }
        //} 


        public override string ToString()
        {
            return Id + " " + FirstName + " " + LastName + " " + Year + " ";
        }
    }
}
