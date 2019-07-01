using AdventurersWanted.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventurersWanted.Data
{
    public class DbSeeder
    {
        private readonly EntityContext _ctx;
        private readonly IHostingEnvironment _hosting;

        public DbSeeder(EntityContext ctx, IHostingEnvironment hosting)
        {
            _ctx = ctx;
            _hosting = hosting;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();

            if (!_ctx.Campaigns.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/campaign.json");
                var json = File.ReadAllText(filepath);
                var campaigns = JsonConvert.DeserializeObject<IEnumerable<Campaign>>(json);
                _ctx.Campaigns.AddRange(campaigns);

                _ctx.SaveChanges();
            }
        }
    }
}
