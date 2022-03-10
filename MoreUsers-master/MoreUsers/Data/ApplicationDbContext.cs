using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoreUsers.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using MoreUsers.Models;

namespace MoreUsers.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
