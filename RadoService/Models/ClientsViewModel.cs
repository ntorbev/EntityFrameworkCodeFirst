using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RadoService.DAl;

namespace RadoService.Models
{
    public class ClientsViewModel
    {
        //public int ClientID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public int? age { get; set; }
        public int? phone { get; set; }
        public string defect { get; set; }
        public int? price { get; set; }
        public DateTime? date { get; set; }
        public DateTime? deadLine { get; set; }

        public ClientsViewModel(RadoService.DAl.Client client)
        {
            this.age = client.age;
            this.firstName = client.firstName;
            this.lastName = client.lastName;
            this.address = client.address;
            this.phone = client.phone;
            this.defect = client.defect;
            this.price = client.price;
            this.date = client.date;
            this.deadLine = client.deadLine;
        }
    }
}