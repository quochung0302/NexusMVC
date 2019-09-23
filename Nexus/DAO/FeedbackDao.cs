using Nexus.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nexus.DAO
{
    public class FeedbackDao
    {
        private NexusDbContext db = null;
        public FeedbackDao()
        {
            db = new NexusDbContext();
        }
        public Feedback AddMessage(Feedback fb)
        {
            db.Feedbacks.Add(fb);
            db.SaveChanges();
            return fb;
        }
    }
}