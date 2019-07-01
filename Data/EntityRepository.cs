using AdventurersWanted.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventurersWanted.Data
{
    public class EntityRepository
    {
        private readonly EntityContext _ctx;

        public EntityRepository(EntityContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Campaign> GetAllCampaigns()
        {
            return _ctx.Campaigns.ToList();
        }

        // get by category etc.

        // save
        public bool SaveAll()
        {
           return _ctx.SaveChanges() > 0;
        }
    }
}
