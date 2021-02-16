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
                new Domain.Models.Movie() { Id = 1, Title = "Tenet", Director = "Christopher Nolan", ReleaseDate = DateTime.Parse("2020-08-26"), Genre = "Action/Sci-fi", Technology = "2D", Language = "English", Description = "She is a angel princess from the angel world. She grew up loved by her parents and doesn't really know how to be evil or any of the common actions,   She is unable to cry due to Keita's accidental first wish, despite needed for him to wish." },
                new Domain.Models.Movie() { Id = 2, Title = "Palm Springs", Director = "Max Barbakow", ReleaseDate = DateTime.Parse("2020-01-26"), Genre = "Romantic comedy", Technology = "2D", Language = "English", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." },
                new Domain.Models.Movie() { Id = 3, Title = "The Assistant", Director = "Kitty Green", ReleaseDate = DateTime.Parse("2019-08-30"), Genre = "Drama", Technology = "2D", Language = "English", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." },
                new Domain.Models.Movie() { Id = 4, Title = "Honeyland", Director = "Tamara Kotevska", ReleaseDate = DateTime.Parse("2019-01-28"), Genre = "Documentary", Technology = "2D", Language = "Macedonian", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." },
                new Domain.Models.Movie() { Id = 5, Title = "Parasite", Director = "Bong Joon-ho", ReleaseDate = DateTime.Parse("2019-05-30"), Genre = "Dark comedy", Technology = "2D", Language = "Korean", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." },
                new Domain.Models.Movie() { Id = 6, Title = "The midnight sky", Director = "George Clooney", ReleaseDate = DateTime.Parse("2020-12-09"), Genre = "Action/Sci-fi", Technology = "2D", Language = "English", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." },
                new Domain.Models.Movie() { Id = 7, Title = "Wonder Woman", Director = "Patty Jenkins", ReleaseDate = DateTime.Parse("2020-12-16"), Genre = "Action/Sci-fi", Technology = "2D", Language = "English", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." },
                new Domain.Models.Movie() { Id = 8, Title = "Birds of Prey", Director = "Cathy Yan", ReleaseDate = DateTime.Parse("2020-01-26"), Genre = "Action", Technology = "2D", Language = "English", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." },
                new Domain.Models.Movie() { Id = 9, Title = "Possessor", Director = "Brandon Cronenberg", ReleaseDate = DateTime.Parse("2020-10-02"), Genre = "Sci-fi/Horror", Technology = "2D", Language = "English", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." },
                new Domain.Models.Movie() { Id = 10, Title = "Mulan", Director = "Niki Caro", ReleaseDate = DateTime.Parse("2020-09-04"), Genre = "Action", Technology = "2D", Language = "English", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." }
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
                },
                 new Actor()
                 {
                     Id = 7,
                     FirstName = "Song",
                     LastName = "Kang-ho",
                     Age = 53
                 },
                  new Actor()
                  {
                      Id = 8,
                      FirstName = "George",
                      LastName = "Clooney",
                      Age = 59
                  },
                  new Actor()
                  {
                      Id = 9,
                      FirstName = "Chris",
                      LastName = "Pine",
                      Age = 40
                  },
                   new Actor()
                   {
                       Id = 10,
                       FirstName = "Margot",
                       LastName = "Robbie",
                       Age = 40
                   },
                   new Actor()
                   {
                       Id = 11,
                       FirstName = "Christopher",
                       LastName = "Abbott",
                       Age = 34
                   },
                  new Actor()
                  {
                      Id = 12,
                      FirstName = "Liu",
                      LastName = "Yifei",
                      Age = 33
                  });

            modelBuilder.Entity<Cast>()
                        .HasData(
                 new Cast()
                 {
                     Id = 1,
                     MovieId = 1,
                     ActorId = 2
                 },
                 new Cast()
                 {
                     Id = 2,
                     MovieId = 2,
                     ActorId = 4
                 },
                 new Cast()
                 {
                     Id = 3,
                     MovieId = 3,
                     ActorId = 1
                 },
                 new Cast()
                 {
                     Id = 4,
                     MovieId = 4,
                     ActorId = 6
                 },
                 new Cast()
                 {
                     Id = 5,
                     MovieId = 5,
                     ActorId = 7
                 },
                 new Cast()
                 {
                     Id = 6,
                     MovieId = 6,
                     ActorId = 8
                 },
                 new Cast()
                 {
                     Id = 7,
                     MovieId = 7,
                     ActorId = 9
                 },
                new Cast()
                {
                    Id = 8,
                    MovieId = 8,
                    ActorId = 10
                },
                new Cast()
                {
                    Id = 9,
                    MovieId = 9,
                    ActorId = 11
                },
                new Cast()
                {
                    Id = 10,
                    MovieId = 10,
                    ActorId = 12
                },
                new Cast()
                {
                    Id = 11,
                    MovieId = 3,
                    ActorId = 3
                },
                new Cast()
                {
                    Id = 12,
                    MovieId = 2,
                    ActorId = 5
                });

            modelBuilder.Entity<Hall>()
                        .HasData(
                         new Hall()
                         {
                             Id = 1,
                             Name = "Hall 01",
                             Type = "Standard"
                         });

            modelBuilder.Entity<Show>()
                        .HasData(
                         new Show()
                         {
                             Id = 1,
                             MovieId = 1,
                             HallId = 1,
                             StartDate = DateTime.Parse("2020-09-10"),
                             EndDate = DateTime.Parse("2020-09-30"),
                             ShowTime = DateTime.Parse("2020-09-10").AddHours(1)
                         },
                         new Show()
                         {
                             Id = 2,
                             MovieId = 2,
                             HallId = 1,
                             StartDate = DateTime.Parse("2020-02-10"),
                             EndDate = DateTime.Parse("2020-03-02"),
                             ShowTime = DateTime.Parse("2020-02-10").AddHours(2)
                         },
                         new Show()
                         {
                             Id = 3,
                             MovieId = 3,
                             HallId = 1,
                             StartDate = DateTime.Parse("2020-01-01"),
                             EndDate = DateTime.Parse("2020-02-02"),
                             ShowTime = DateTime.Parse("20-01-01").AddHours(4)
                         },
                         new Show()
                         {
                             Id = 4,
                             MovieId = 4,
                             HallId = 1,
                             StartDate = DateTime.Parse("2019-06-05"),
                             EndDate = DateTime.Parse("2019-07-10"),
                             ShowTime = DateTime.Parse("2019-06-05").AddHours(3)
                         },
                         new Show()
                         {
                             Id = 5,
                             MovieId = 5,
                             HallId = 1,
                             StartDate = DateTime.Parse("2019-10-01"),
                             EndDate = DateTime.Parse("2019-11-10"),
                             ShowTime = DateTime.Parse("2019-10-01").AddHours(3)
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
