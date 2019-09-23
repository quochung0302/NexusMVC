using Nexus.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nexus.DAO
{
    
    public class AdvantageDao
    {
        private NexusDbContext db = null;
        public AdvantageDao()
        {
            db = new NexusDbContext();
        }
        public List<Advantage> GetList()
        {
            var list = db.Advantages.ToList();
            return list;
            
        }

    }
}