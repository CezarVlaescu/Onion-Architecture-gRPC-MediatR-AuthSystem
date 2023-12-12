using Core_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Infrastructure_Layer.Data
{
    // Entity framework DbContext
    public class ApplicationDbContext : DbContext
    {
        // Define DbSets for entities

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public Microsoft.EntityFrameworkCore.DbSet<Entity>? EntityContext {  get; set; }
    }
}
