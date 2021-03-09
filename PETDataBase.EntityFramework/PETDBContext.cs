using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PETDataBase.Domain.Models;

namespace PETDataBase.EntityFramework
{
    public class PETDBContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Informant> Informants { get; set; }


        public DbSet<Report> Reports { get; set; }
        public DbSet<Comment> Comments { get; set; }
        

        public DbSet<Observant> Observants { get; set; }
        public DbSet<Group> Groups { get; set; }


        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PETDataBase;Trusted_Connection=True;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
