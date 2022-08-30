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
        }
        }
}

