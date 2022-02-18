using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandsSalesWebApi.Models {
    public class AppDbContext : DbContext {

        public virtual DbSet<Customer> Customers { get; set; }

        //constructer - no need for the default constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //used to make a non PK column unique
        protected override void OnModelCreating(ModelBuilder builder) {


        }

    }
}
