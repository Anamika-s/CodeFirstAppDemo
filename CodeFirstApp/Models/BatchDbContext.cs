using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    class BatchDbContext : DbContext
    {
        
        public DbSet<Batch> Batches { get; set; }
    }
}
