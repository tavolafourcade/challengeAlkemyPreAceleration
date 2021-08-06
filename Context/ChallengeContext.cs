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
        private const string Schema = "icons";
        public ChallengeContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema(Schema);

            // Segunda forma de establecer relaciones con Fluent API (permite detallar las propiedades y funcionalidades que se quiere que tenga la tabla)

            /* La ciudad tiene un Continente con muchas ciudades y la Foreign Key va a ser ContinentId
             * builder.Entity<City>()
                .HasOne<Continent>()
                .WithMany()
                .HasForeignKey(x => x.ContinentId);

            builder.Entity<Continent>().HasMany<City>();
            */

            builder.Entity<Continent>().HasData(
                new Continent
                {
                    Id = 1,
                    Denomination = "Europa",
                    Image = "TestImage"
                });
        }

        public DbSet<Continent> Continents { get; set; } = null;

        public DbSet<City> City { get; set; } = null;

        public DbSet<GeographicIcons> GeographicIcons { get; set; } = null;
    }
}
