namespace Nexus.Migrations
{
    using Nexus.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Nexus.Models.NexusContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Nexus.Models.NexusContext context)
        {
            var avantages = new List<Advantage>
            {
                new Advantage { Name = "Easy to use",   Title = "We are here to listen from you deliver exellence",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp or incididunt ut labore et dolore magna aliqua. Ut enim ad minim." },
                new Advantage { Name = "Unlimited Colors",   Title = "VECHRO through its Color Palettes PREMIUM COLOR MOODS",
                    Description = " VECHRO through its Color Palettes PREMIUM COLOR MOODS and COLOR MOODS, as well as through its unique Color Brochures" },
                new Advantage { Name = "Unique Features",   Title = "Find and apply to over 5000 casting calls, auditions and roles on Backstage",
                    Description = "Find and apply to over 5000 casting calls, auditions and roles on Backstage, the most trusted platform for actors and models. Start and get cast today!" },
                new Advantage { Name = "And more",   Title = "We are here to listen from you deliver exellence",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp or incididunt ut labore et dolore magna aliqua. Ut enim ad minim." },

            };
            context.Advantages.AddRange(avantages);
            context.SaveChanges();

        }
    }
}
