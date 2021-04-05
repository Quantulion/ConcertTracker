using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Viewer> Viewers { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<ConcertHall> ConcertHalls { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options): base(options) {
            /*Database.EnsureDeleted();
            Database.EnsureCreated();*/
            //Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Like>()
                .HasKey(x => new { x.PersonId, x.CommentId });
            modelBuilder.Entity<Like>()
                .HasOne(x => x.Person)
                .WithMany(m => m.Likes)
                .HasForeignKey(x => x.PersonId);
            modelBuilder.Entity<Like>()
                .HasOne(x => x.Comment)
                .WithMany(e => e.Likes)
                .HasForeignKey(x => x.CommentId);
            modelBuilder.Entity<Comment>()
                .HasOne(x => x.Person)
                .WithMany(e => e.Comments)
                .HasForeignKey(x => x.PersonId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ConcertTrackerDB;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("DataLayer"));
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
