using Lab5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Internal;

namespace Lab5.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Enable Identity Framework
            base.OnModelCreating(modelBuilder);


            // Pre-Seeded Jobs
            var warrior     = new Job { JobId = 1, JobName = "Warrior",     Role = Character.Roles.Tank };
            var paladin     = new Job { JobId = 2, JobName = "Paladin",     Role = Character.Roles.Tank };
            var whiteMage   = new Job { JobId = 3, JobName = "White Mage",  Role = Character.Roles.Healer };
            var shaman      = new Job { JobId = 4, JobName = "Shaman",      Role = Character.Roles.Healer };
            var ninja       = new Job { JobId = 5, JobName = "Ninja",       Role = Character.Roles.MeleeDPS };
            var monk        = new Job { JobId = 6, JobName = "Monk",        Role = Character.Roles.MeleeDPS };
            var blackMage   = new Job { JobId = 7, JobName = "Black Mage",  Role = Character.Roles.MagicDPS };
            var necromancer = new Job { JobId = 8, JobName = "Necromancer", Role = Character.Roles.MagicDPS };

            // Add Pre-Seeded data to DB on creation
            modelBuilder.Entity<Job>().HasData(warrior, paladin, whiteMage, shaman, ninja, monk, blackMage, necromancer);
        }

        // DB Tables
        public DbSet<Character> Characters { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}