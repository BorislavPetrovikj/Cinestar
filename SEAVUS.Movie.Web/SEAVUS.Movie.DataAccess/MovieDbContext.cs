using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SEAVUS.Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.DataAccess
{
    public class MovieDbContext : IdentityDbContext<User>
    {
        public MovieDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Domain.Models.Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cast> Cast { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        public void Seed(ModelBuilder modelBuilder)
        {
            string adminId = Guid.NewGuid().ToString();
            string adminRoleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();

            var haser = new PasswordHasher<User>();

            modelBuilder.Entity<User>()
                        .HasData(
                        new User
                        {
                            Id = adminId,
                            UserName = "AngelaAdmin",
                            NormalizedUserName = "ADMIN",
                            Email = "angelaadmin@gmail.com",
                            NormalizedEmail = "angelaadmin@gmail.com",
                            EmailConfirmed = true,
                            PasswordHash = haser.HashPassword(null, "Admin123#"),
                            SecurityStamp = string.Empty
                        });
            modelBuilder.Entity<IdentityRole>()
                        .HasData(
                        new IdentityRole
                        {
                            Id = adminRoleId,
                            Name = "admin",
                            NormalizedName = "Administrator"
                        },
                        new IdentityRole 
                        { 
                            Id = userRoleId,
                            Name = "user",
                            NormalizedName = "User"
                        
                        });

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = adminRoleId,
                        UserId = adminId
                    });

            modelBuilder.Entity<Domain.Models.Movie>()
                .HasData(
                new Domain.Models.Movie() { Id = 1, Title = "Tenet", Director = "Christopher Nolan", ReleaseDate = new DateTime(2020-08-26), Genre = "Action/Sci-fi", Technology = "2D", Language="English" },
                new Domain.Models.Movie() { Id = 2, Title = "Palm Springs", Director = "Max Barbakow", ReleaseDate = new DateTime(2020-01-26), Genre = "Romantic comedy", Technology = "2D", Language = "English" },
                new Domain.Models.Movie() { Id = 3, Title = "The Assistant", Director = "Kitty Green", ReleaseDate = new DateTime(2019-08-30), Genre = "Drama", Technology = "2D", Language = "English" },
                new Domain.Models.Movie() { Id = 4, Title = "Honeyland", Director = "Tamara Kotevska", ReleaseDate = new DateTime(2019-01-28), Genre = "Documentary", Technology = "2D", Language = "Macedonian" },
                new Domain.Models.Movie() { Id = 5, Title = "Parasite", Director = "Bong Joon-ho", ReleaseDate = new DateTime(2019-05-30), Genre = "Dark comedy", Technology = "2D", Language = "Korean" },
                new Domain.Models.Movie() { Id = 6, Title = "The midnight sky", Director = "George Clooney", ReleaseDate = new DateTime(2020-12-09), Genre = "Action/Sci-fi", Technology = "2D", Language = "English" },
                new Domain.Models.Movie() { Id = 7, Title = "Wonder Woman", Director = "Patty Jenkins", ReleaseDate = new DateTime(2020-12-16), Genre = "Action/Sci-fi", Technology = "2D", Language = "English" },
                new Domain.Models.Movie() { Id = 8, Title = "Birds of Prey", Director = "Cathy Yan", ReleaseDate = new DateTime(2020-01-26), Genre = "Action", Technology = "2D", Language = "English" },
                new Domain.Models.Movie() { Id = 9, Title = "Possessor", Director = "Brandon Cronenberg", ReleaseDate = new DateTime(2020-10-02), Genre = "Sci-fi/Horror", Technology = "2D", Language = "English" },
                new Domain.Models.Movie() { Id = 10, Title = "Mulan", Director = "Niki Caro", ReleaseDate = new DateTime(2020-09-04), Genre = "Action", Technology = "2D", Language = "English" }
                );

            modelBuilder.Entity<Actor>()
                .HasData(
                new Actor()
                {
                    Id = 1,
                    FirstName = "Patrick",
                    LastName = "Wilson",
                    Age = 41
                },
                new Actor()
                {
                    Id = 2,
                    FirstName = "Elizabeth",
                    LastName = "Debicki",
                    Age = 30
                },
                new Actor()
                {
                    Id = 3,
                    FirstName = "Julia",
                    LastName = "Garner",
                    Age = 26
                },
                new Actor()
                {
                    Id = 4,
                    FirstName = "Andy",
                    LastName = "Samberg",
                    Age = 42
                },
                new Actor()
                {
                    Id = 5,
                    FirstName = "Cristin",
                    LastName = "Milioti",
                    Age = 35
                },
                new Actor()
                {
                    Id = 6,
                    FirstName = "Hatidze",
                    LastName = "Muratova",
                    Age = 60
                });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<User>()
                .HasMany(x => x.Reservations)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Tickets)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Actor>()
                .HasMany(x => x.MovieCast)
                .WithOne(x => x.Actor)
                .HasForeignKey(x => x.ActorId);

            modelBuilder.Entity<Domain.Models.Movie>()
                .HasMany(x => x.MovieCast)
                .WithOne(x => x.Movie)
                .HasForeignKey(x => x.MovieId);

            modelBuilder.Entity<Domain.Models.Movie>()
              .HasMany(x => x.Shows)
              .WithOne(x => x.Movie)
              .HasForeignKey(x => x.MovieId);

            modelBuilder.Entity<Hall>()
             .HasMany(x => x.Shows)
             .WithOne(x => x.Hall)
             .HasForeignKey(x => x.HallId);

            modelBuilder.Entity<Hall>()
             .HasMany(x => x.Seats)
             .WithOne(x => x.Hall)
             .HasForeignKey(x => x.HallId);

            modelBuilder.Entity<Show>()
            .HasMany(x => x.Reservations)
            .WithOne(x => x.Show)
            .HasForeignKey(x => x.ShowId);

            modelBuilder.Entity<Show>()
            .HasMany(x => x.Tickets)
            .WithOne(x => x.Show)
            .HasForeignKey(x => x.ShowId);

            modelBuilder.Entity<Seat>()
            .HasMany(x => x.Reservations)
            .WithOne(x => x.Seat)
            .HasForeignKey(x => x.SeatId);

            modelBuilder.Entity<Seat>()
           .HasMany(x => x.Tickets)
           .WithOne(x => x.Seat)
           .HasForeignKey(x => x.SeatId);

            modelBuilder.Entity<Reservation>()
           .HasMany(x => x.Tickets)
           .WithOne(x => x.Reservation)
           .HasForeignKey(x => x.SeatId);

            Seed(modelBuilder);
        }
    }
}
