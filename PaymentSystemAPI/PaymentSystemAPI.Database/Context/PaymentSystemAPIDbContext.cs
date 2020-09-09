using Microsoft.EntityFrameworkCore;
using PaymentSystemAPI.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSystemAPI.Database.Context
{
    public class PaymentSystemAPIDbContext : DbContext 
    {
        public DbSet<PaymentDetail> PaymentDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source = DESKTOP-HHA0TOP; 
                                    Initial Catalog = PaymentSystemAPIDb; 
                                    Integrated Security = SSPI;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
