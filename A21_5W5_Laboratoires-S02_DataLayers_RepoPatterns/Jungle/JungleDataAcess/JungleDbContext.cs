using Microsoft.EntityFrameworkCore;
using System;

namespace JungleDataAcess
{
    public class JungleDbContext : DbContext
    {
        public JungleDbContext(DbContextOptions<JungleDbContext> options) : base(options)
        {

        }



    }
}
