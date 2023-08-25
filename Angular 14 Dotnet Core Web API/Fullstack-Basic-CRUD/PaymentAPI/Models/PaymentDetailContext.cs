using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PaymentAPI.Models
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions options) : base(options)
        {
        }

        // Telling DBContext that we need a corresponding physical table to PaymentDetail
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}