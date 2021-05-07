using DataLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Viewer> Viewers { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<ConcertHall> ConcertHalls { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options): base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserComment>()
                .HasKey(x => new { x.UserId, x.CommentId });
            modelBuilder.Entity<UserComment>()
                .HasOne(x => x.User)
                .WithMany(m => m.Likes)
                .HasForeignKey(x => x.UserId);
            modelBuilder.Entity<UserComment>()
                .HasOne(x => x.Comment)
                .WithMany(e => e.Likes)
                .HasForeignKey(x => x.CommentId);
            modelBuilder.Entity<Comment>()
                .HasOne(x => x.User)
                .WithMany(e => e.Comments)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=USER-PC;Database=ConcertTrackerDB;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("DataLayer"));
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
