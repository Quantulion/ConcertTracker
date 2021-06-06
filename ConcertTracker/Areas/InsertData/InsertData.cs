using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using Bogus.Locations;
using BusinessLayer;
using DataLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Radzen;

namespace ConcertTracker.Areas.InsertData
{
    public class InsertData : IInsertData
    {
        private readonly ApplicationDbContext _ctx;
        private readonly UserManager<User> _userManager;
        private readonly DataManager _dataManager;
        public InsertData(ApplicationDbContext ctx, 
            UserManager<User> userManager,
            DataManager dataManager)
        {
            _ctx = ctx;
            _userManager = userManager;
            _dataManager = dataManager;
        }

        public async Task InsertAllData(int number)
        {
            await InsertUsers(number);
            await InsertArtists(number);
            await InsertConcertHalls(number);
            await InsertConcerts(number);
            await InsertComments(number);
        }

        public async Task InsertUsers(int number)
        {
            var userFaker = new Faker<User>()
                .RuleFor(x => x.UserName, x => x.Person.UserName)
                .RuleFor(x => x.Age, x => x.Person.DateOfBirth.Hour)
                .RuleFor(x => x.Description, x => x.Person.FullName)
                .RuleFor(x => x.Email, x => x.Person.Email)
                .RuleFor(x => x.Photo, x => x.Internet.Avatar())
                .RuleFor(x => x.PhoneNumber, x => x.Person.Phone);

            for (int i = 0; i < number; i++)
            {
                var user = userFaker.Generate();
                var x = new Faker().Internet.Password();
                await _userManager.CreateAsync(user, x);
            }
        }

        public async Task InsertArtists(int number)
        {
            var artistFakes = new Faker<Artist>()
                .RuleFor(x => x.UserName, x => x.Person.UserName)
                .RuleFor(x => x.Age, x => x.Person.DateOfBirth.Hour)
                .RuleFor(x => x.Description, x => x.Person.FullName)
                .RuleFor(x => x.Email, x => x.Person.Email)
                .RuleFor(x => x.Photo, x => x.Internet.Avatar())
                .RuleFor(x => x.PhoneNumber, x => x.Person.Phone);

            for (int i = 0; i < number; i++)
            {
                var artist = artistFakes.Generate();
                var x = new Faker().Internet.Password();
                var result = await _userManager.CreateAsync(artist, x);
                if (result.Succeeded)
                    await _userManager.AddToRoleAsync(artist, "Artist");
            }

        }

        public async Task InsertConcertHalls(int number)
        {
            var concertHallFaker = new Faker<ConcertHall>()
                .RuleFor(x => x.Address, x => x.Address.StreetAddress())
                .RuleFor(x => x.Description, x => x.Company.CatchPhrase())
                .RuleFor(x => x.Name, x => x.Company.CompanyName())
                .RuleFor(x => x.Photo, x => x.Image.PicsumUrl());
            
            for (int i = 0; i < number; i++)
            {
                var concertHall = concertHallFaker.Generate();
                _ctx.ConcertHalls.Add(concertHall);
                await _ctx.SaveChangesAsync();
            }
        }

        public async Task InsertConcerts(int number)
        {
            var concertFaker = new Faker<Concert>()
                .RuleFor(x => x.Date, x => x.Date.Future())
                .RuleFor(x => x.Description, x => x.Company.CatchPhrase());

            for (int i = 0; i < number; i++)
            {
                var x = new Faker().Location().AreaCircle(55.7491, 37.6258, 100000).Latitude;
                var y = new Faker().Location().AreaCircle(55.7491, 37.6258, 100000).Longitude;
                var concert = concertFaker.Generate();
                var artist = await GetRandomArtist();
                var concertHall = await GetRandomConcertHall();
                concert.Artists = new List<Artist>();
                concert.Position = new GoogleMapPosition();
                concert.Artists.Add(artist);
                concert.ConcertHall = concertHall;
                concert.Position.Lat = x;
                concert.Position.Lng = y;
                await _dataManager.Concerts.AddConcertAsync(concert);
            }
        }

        public async Task InsertComments(int number)
        {
            var commentFaker = new Faker<Comment>()
                .RuleFor(x => x.Content, x => x.Company.CatchPhrase());
            
            for (int i = 0; i < number; i++)
            {
                var comment = commentFaker.Generate();
                var artist = await GetRandomArtist();
                var concert = await GetRandomConcert();
                comment.User = artist;
                comment.Concert = concert;
                await _dataManager.Comments.AddCommentAsync(comment, artist, concert);
            }
        }

        private async Task<ConcertHall> GetRandomConcertHall()
        {
            var concertHalls = await _dataManager.ConcertHalls.GetAllConcertHallsAsync();
            var rnd = new Randomizer().Int(1, concertHalls.Count - 1);
            return concertHalls.ToList()[rnd];
        }
        private async Task<Artist> GetRandomArtist()
        {
            var artists = await _dataManager.Artists.GetAllArtistsAsync();
            var rnd = new Randomizer().Int(1, artists.Count - 1);
            return artists.ToList()[rnd];
        }
        private async Task<Concert> GetRandomConcert()
        {
            var concerts = await _dataManager.Concerts.GetAllConcertsAsync();
            var rnd = new Randomizer().Int(1, concerts.Count - 1);
            return concerts.ToList()[rnd];
        }
    }
}