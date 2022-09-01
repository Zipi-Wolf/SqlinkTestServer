using Microsoft.EntityFrameworkCore;
using SqlinkTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlinkTest.Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
         public DbSet<Project> projects { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserLoginDetails> userLogins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.id).ValueGeneratedNever();

                entity.Property(e => e.name).IsUnicode(false);

                entity.Property(e => e.score).IsUnicode(false);

                entity.Property(e => e.durationInDays).IsUnicode(false);

                entity.Property(e => e.madeDadeline).IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {

                entity.Property(e => e.name).IsUnicode(false);

                entity.Property(e => e.team).IsUnicode(false);

                entity.Property(e => e.joinedAt).IsUnicode(false);

                entity.Property(e => e.avatar).IsUnicode(false);
            });

            modelBuilder.Entity<UserLoginDetails>(entity =>
            {

                entity.Property(e => e.userId).IsUnicode(false);

                entity.Property(e => e.email).IsUnicode(false);

                entity.Property(e => e.password).IsUnicode(false);
            });
        }
        }
}

