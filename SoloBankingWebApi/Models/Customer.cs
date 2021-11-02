﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoloBankingWebApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(30), Required]
        public string UserName { get; set; }
        [StringLength(30), Required]
        public string Password { get; set; }
        [StringLength(30), Required]
        public string FirstName { get; set; }
        [StringLength(30), Required]
        public string LastName { get; set; }
        [StringLength(30), Required]
        public string Address { get; set; }
        [StringLength(30), Required]
        public string City { get; set; }
        [StringLength(2), Required]
        public string State { get; set; }
        [StringLength(5), Required]
        public string Zip { get; set; }
        [StringLength(14)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
    }
}
