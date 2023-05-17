using FitnessClub3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace FitnessClub3.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<IndividualTraining> IndividualTrainings { get; set; }
        public DbSet<GroupTraining> GroupTrainings { get; set; }
        public DbSet<GroupTrainingUser> GroupTrainingUsers { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            const string admin_id = "a53f0179-0c73-43df-a2ee-f4aaff1b6069";
            const string adminRoleId = "a23d0179-0c73-43df-a2ee-f4scff1b6062";
            const string SportsManRoleId = "b44d0179-0c73-43df-a2ee-f4scff1b6062";
            const string IndividualTrainerRoleId = "d54d0179-1a22-43df-a2ee-f4scff1b6062";
            const string GroupTrainerRoleId = "a23d0179-0c73-43df-e5ee-f4scff1b6062";

            var adminRole = new IdentityRole
            {
                Id = adminRoleId,
                Name = "Админ",
                NormalizedName = "АДМИН"
            };
            var SportsManRole = new IdentityRole
            {
                Id = SportsManRoleId,
                Name = "Спортист",
                NormalizedName = "СПОРТИСТ"
            };
            var IndividualTrainerRole = new IdentityRole
            {
                Id = IndividualTrainerRoleId,
                Name = "Индивидуален Треньор",
                NormalizedName = "ИНДИВИДУАЛЕН ТРЕНЬОР"
            };
            var GroupTrainerRole = new IdentityRole
            {
                Id = GroupTrainerRoleId,
                Name = "Групов Треньор",
                NormalizedName = "ГРУПОВ ТРЕНЬОР"
            };

            var admin = new ApplicationUser
            {
                Id = admin_id,
                Name = "Иво",
                LastName = "Стоянов",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                NormalizedEmail = "admin@abv.bg",
                Email = "admin@abv.bg"
            };

            var ph = new PasswordHasher<ApplicationUser>();
            admin.PasswordHash = ph.HashPassword(admin, "12345678");
            builder.Entity<ApplicationUser>().HasData(admin);
            builder.Entity<IdentityRole>().HasData(adminRole);
            builder.Entity<IdentityRole>().HasData(SportsManRole);
            builder.Entity<IdentityRole>().HasData(IndividualTrainerRole);
            builder.Entity<IdentityRole>().HasData(GroupTrainerRole);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = admin_id
            });
        }

    }
}
