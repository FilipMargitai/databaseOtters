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
            var loc1 = new Location { LocationID = 111, Name = "NP Šumava", Area = 33233 };
            var loc2 = new Location { LocationID = 128, Name = "CHKO Jizerské hory", Area = 13165 };
            var loc3 = new Location { LocationID = 666, Name = "CHKO Čeký Les", Area = 15432 };

            modelBuilder.Entity<Place>(
                  p =>
                  {
                      p.HasMany(pl => pl.Otters).WithOne(ot => ot.Place).HasForeignKey(ot => new { ot.PlaceName, ot.LocationId });
                  }
                );

            modelBuilder.Entity<Location>().HasData(loc1, loc2, loc3);

            modelBuilder.Entity<Place>().HasKey(p => new { p.Name, p.LocationId });

            var plc1 = new Place { Name = "U Studánky", LocationId = 111 };
            var plc2 = new Place { Name = "Černé Jezero", LocationId = 128 };
            var plc3 = new Place { Name = "U Studánky", LocationId = 128 };

            modelBuilder.Entity<Place>().HasData(
                    plc1,
                    new Place { Name = "U Buku", LocationId = 111},
                    plc2,
                    plc3,
                    new Place { Name = "Na Čihadlech", LocationId = 128},
                    new Place { Name = "U Studánky", LocationId = 666},
                    new Place { Name = "Český Pařez", LocationId = 666}
                );

            var pramatka = new Otter { Name = "Velká Máti", TattooID = 1, Color = "hnědá jako hodně", PlaceName = "U Studánky", LocationId = 111 };
            modelBuilder.Entity<Otter>().HasData(
                    pramatka,
                    new Otter { Name = "První Dcera", TattooID = 2, Color = "Hnědá taky", MotherId = 1, PlaceName = "U Studánky", LocationId = 111  },
                    new Otter { Name = "ZBloudilka", TattooID = 3, Color = "Hnědá trochu", MotherId = 1, PlaceName = "Černé Jezero", LocationId = 128 }
                );
        }
    }
}
