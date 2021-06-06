using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DataLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConcertTracker.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IGenreRepository _genreRepository;

        public IndexModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IGenreRepository genreRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _genreRepository = genreRepository;
        }
        [Display(Name = "Photo")]
        public string PhotoPath { get; set; }
        public string Username { get; set; }
        public ICollection<Genre> AllGenres { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            [Display(Name = "Age")]
            public int Age { get; set; }

            [Display(Name = "About")]
            public string Description { get; set; }

            public List<string> Genres { get; set; } = new List<string>();
        }

        private async Task LoadAsync(User user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var age = user.Age;
            var description = user.Description;
            
            AllGenres = await _genreRepository.GetAllGenresAsync();
            Username = userName;
            PhotoPath = user.Photo;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                Age = age,
                Description = description
            };
            if (await _userManager.IsInRoleAsync(user, "Artist"))
            {
                Artist artist = (Artist) user;
                var genres = await _genreRepository.GetGenresOfArtistAsync(artist);
                foreach (var genre in genres)
                {
                    Input.Genres.Add(genre.Name);
                }
            }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            var age = user.Age;
            if (Input.Age != age)
            {
                user.Age = Input.Age;
                var setAgeResult = await _userManager.UpdateAsync(user);
                if (!setAgeResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set Age.";
                    return RedirectToPage();
                }
            }

            var description = user.Description;
            if (Input.Description != description)
            {
                user.Description = Input.Description;
                var setDescriptionResult = await _userManager.UpdateAsync(user);
                if (!setDescriptionResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set Description.";
                    return RedirectToPage();
                }
            }
            
            if (await _userManager.IsInRoleAsync(user, "Artist"))
            {
                Artist artist = (Artist) user;
                var genres = await _genreRepository.GetGenresOfArtistAsync(artist);
                List<Genre> inputGenres = new List<Genre>();
                foreach (var genreName in Input.Genres)
                {
                    var currentGenre = await _genreRepository.GetGenreByNameAsync(genreName);
                    inputGenres.Add(currentGenre);
                }
                if (inputGenres != genres.ToList())
                    {
                        artist.Genres = inputGenres;
                        var setGenresResult = await _userManager.UpdateAsync(user);
                        if (!setGenresResult.Succeeded)
                        {
                            StatusMessage = "Unexpected error when trying to set Genres.";
                            return RedirectToPage();
                        }
                    }
            }
            
            

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
