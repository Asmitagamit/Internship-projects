using Microsoft.EntityFrameworkCore;
using Mission.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Entities.context
{
    public class MissionDbContext : DbContext
    {
        public MissionDbContext(DbContextOptions<MissionDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehaviour", true);
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                First_Name = "Tatva",
                Last_Name = "Admin",
                EmailAddress = "admin@tatvasoft.com",
                UserType = "admin",
                Password = "Tatva@123",
                PhoneNumber = "9876543210",
                CreateDate = new DateTime(2019, 1, 1, 0, 0, 0, DateTimeKind.Utc)


            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
