using JungleModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace JungleDataAcess
{
    public class JungleDbContext : DbContext
    {

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<TravelRecommendation> TravelRecommendations { get; set; }


        public JungleDbContext(DbContextOptions<JungleDbContext> options) : base(options)
        {

        }



    }
}
