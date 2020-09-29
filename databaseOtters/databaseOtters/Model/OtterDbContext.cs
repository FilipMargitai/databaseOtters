using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace databaseOtters.Model
{
    public class OtterDbContext : DbContext
    {
        public OtterDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Otter> Otters { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var loc1 = new Location { LocationID = 111, Name = "Šumava", Area = 33233 };
            var loc2 = new Location { LocationID = 128, Name = "Jizerské hory", Area = 13165 };
            var loc3 = new Location { LocationID = 76, Name = "Český les", Area = 15478 };

            modelBuilder.Entity<Place>(
                    p =>
                    {
                        p.HasMany(pl => pl.Otters).WithOne(ot => ot.place);
                    }
                );

            modelBuilder.Entity<Location>().HasData(loc1, loc2, loc3);

            modelBuilder.Entity<Place>().HasKey(p => new { p.Name, p.LocationId }); // složené id (z jména a lokace)

            var plc1 = new Place { Name = "U Studánky", LocationId = 111 };
            var plc2 = new Place { Name = "U Buku", LocationId = 128 };
            var plc3 = new Place { Name = "Černé jezero", LocationId = 128 };

            modelBuilder.Entity<Place>().HasData(
                plc1, 
                plc2, 
                new Place { Name = "U Studánky", LocationId = 76},
                plc3,
                new Place { Name = "Slovenský pařez", LocationId = 128},
                new Place { Name = "Šalina", LocationId = 76}
                );

            var pramatka = new Otter { Name = "Matějova máma", tattooID = 1, Color = "žlutá", PlaceName = "U Studánky" };

            modelBuilder.Entity<Otter>().HasData(
                pramatka,
                new Otter { Name = "Magnet", tattooID = 11, Color = "negr", PlaceName = "Černé jezero", Mother = pramatka},
                new Otter { Name = "Macháček", tattooID = 21, Color = "lososová", PlaceName = "U Studánky", Mother = pramatka }
                );
        }
    }
}
