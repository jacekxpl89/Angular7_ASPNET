using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reklamacja.Models
{
    public class Complaint_context :DbContext
    {

        public Complaint_context(): base("name=Conn")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Complaint> Complaint { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}