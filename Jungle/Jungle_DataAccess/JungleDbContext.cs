using Jungle_DataAccess.Repository;
using Jungle_Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess
{
    public class JungleDbContext : IdentityDbContext
    {
        public JungleDbContext(DbContextOptions<JungleDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuration fluent API


            //Générer des données de départ
            modelBuilder.GenerateData();




            base.OnModelCreating(modelBuilder);

        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Guide> Guide { get; set; }
        public DbSet<Travel> Travel { get; set; }
        public DbSet<TravelRecommendation> TravelRecommendation { get; set; }
        public DbSet<Destination> Destination { get; set; }
        public DbSet<Country> Country { get; set; }

    }
}
