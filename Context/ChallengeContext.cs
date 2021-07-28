using Challenge.PreAceleracion.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.PreAceleracion.Context
{
    public class ChallengeContext : DbContext
    {
        public ChallengeContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Continent> Continents { get; set; } = null;

        public DbSet<City> City { get; set; } = null;

        public DbSet<GeographicIcons> GeographicIcons { get; set; } = null;
    }
}
