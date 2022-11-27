using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NotesApplication.Domain.Aggregates;
using NotesApplication.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.Infrastructure
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new NoteConfig());

            modelBuilder.Entity<User>().HasData(User.CreateUser("Marcin", "Koperczuk"));
        }
    }
}
