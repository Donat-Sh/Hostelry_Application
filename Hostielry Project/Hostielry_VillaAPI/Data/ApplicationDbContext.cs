using HostelryAPI.APIModels.UserModels;
using HostelryAPI.APIModels.VM;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
              new Villa
              {
                  Id = 1,
                  Name = "Royal Hostelry",
                  Details = "From the outside this house looks cozy. It has been built with tan bricks and has sandstone decorations. Tall, rounded windows allow enough light to enter the home and have been added to the house in a mostly symmetric way. The house is equipped with a huge kitchen and two bathrooms, it also has a comfortable living room, three bedrooms, a roomy dining room, an office and a spacious garage. The building is shaped like a circle. The house is partially surrounded by wooden overhanging panels on two sides. The second floor is the same size as the first, which has been built exactly on top of the floor below it. This floor has roughly the same style as the floor below.",
                  ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                  Occupancy = 4,
                  Rate = 200,
                  Sqft = 550,
                  Amenity = "",
                  CreatedDate = DateTime.Now
              },
              new Villa
              {
                  Id = 2,
                  Name = "Premium Pool Hostelry",
                  Details = "From the outside this house looks cozy. It has been built with tan bricks and has sandstone decorations. Tall, rounded windows allow enough light to enter the home and have been added to the house in a mostly symmetric way. The house is equipped with a huge kitchen and two bathrooms, it also has a comfortable living room, three bedrooms, a roomy dining room, an office and a spacious garage. The building is shaped like a circle. The house is partially surrounded by wooden overhanging panels on two sides. The second floor is the same size as the first, which has been built exactly on top of the floor below it. This floor has roughly the same style as the floor below.",
                  ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                  Occupancy = 4,
                  Rate = 300,
                  Sqft = 550,
                  Amenity = "",
                  CreatedDate = DateTime.Now
              },
              new Villa
              {
                  Id = 3,
                  Name = "Luxury Pool Hostelry",
                  Details = "From the outside this house looks cozy. It has been built with tan bricks and has sandstone decorations. Tall, rounded windows allow enough light to enter the home and have been added to the house in a mostly symmetric way. The house is equipped with a huge kitchen and two bathrooms, it also has a comfortable living room, three bedrooms, a roomy dining room, an office and a spacious garage. The building is shaped like a circle. The house is partially surrounded by wooden overhanging panels on two sides. The second floor is the same size as the first, which has been built exactly on top of the floor below it. This floor has roughly the same style as the floor below.",
                  ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",
                  Occupancy = 4,
                  Rate = 400,
                  Sqft = 750,
                  Amenity = "",
                  CreatedDate = DateTime.Now
              },
              new Villa
              {
                  Id = 4,
                  Name = "Diamond Hostelry",
                  Details = "From the outside this house looks cozy. It has been built with tan bricks and has sandstone decorations. Tall, rounded windows allow enough light to enter the home and have been added to the house in a mostly symmetric way. The house is equipped with a huge kitchen and two bathrooms, it also has a comfortable living room, three bedrooms, a roomy dining room, an office and a spacious garage. The building is shaped like a circle. The house is partially surrounded by wooden overhanging panels on two sides. The second floor is the same size as the first, which has been built exactly on top of the floor below it. This floor has roughly the same style as the floor below.",
                  ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",
                  Occupancy = 4,
                  Rate = 550,
                  Sqft = 900,
                  Amenity = "",
                  CreatedDate = DateTime.Now
              },
              new Villa
              {
                  Id = 5,
                  Name = "Diamond Pool Hostelry",
                  Details = "From the outside this house looks cozy. It has been built with tan bricks and has sandstone decorations. Tall, rounded windows allow enough light to enter the home and have been added to the house in a mostly symmetric way. The house is equipped with a huge kitchen and two bathrooms, it also has a comfortable living room, three bedrooms, a roomy dining room, an office and a spacious garage. The building is shaped like a circle. The house is partially surrounded by wooden overhanging panels on two sides. The second floor is the same size as the first, which has been built exactly on top of the floor below it. This floor has roughly the same style as the floor below.",
                  ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                  Occupancy = 4,
                  Rate = 600,
                  Sqft = 1100,
                  Amenity = "",
                  CreatedDate = DateTime.Now
              });
        }
    }
}
