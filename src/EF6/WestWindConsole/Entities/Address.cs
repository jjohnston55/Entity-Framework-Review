﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
//        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        public virtual ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
        public virtual ICollection<Supplier> Suppliers { get; set; } = new HashSet<Supplier>();
    }
}
