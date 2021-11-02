using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloBankingWebApi.Models
{
    public class BankingDbContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public BankingDbContext(DbContextOptions<BankingDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder) { }
    }
}
