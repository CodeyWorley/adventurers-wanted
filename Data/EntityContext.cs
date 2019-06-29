using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AdventurersWanted.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace AdventurersWanted.Data
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options): base(options)
        {
        }

        public DbSet<Campaign> Campaigns { get; set; }
    }
}
