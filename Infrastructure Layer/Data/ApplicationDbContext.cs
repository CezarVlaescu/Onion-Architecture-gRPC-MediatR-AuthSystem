using Core_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Data
{
    // Entity framework DbContext
    public class ApplicationDbContext : DbContext
    {
        // Define DbSets for entities

        public DbSet<Entity>? EntityContext {  get; set; }
    }
}
