using Microsoft.AspNetCore.Identity;
using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.Domain.Models;
using SEAVUS.Movie.Services.Interfaces;
using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.Services.Services
{
    public class UserService : IUserService
    {
        protected readonly IUserRepository _userRepository;
        protected readonly SignInManager<User> _signInManager;
        protected readonly UserManager<User> _userManager;

        public UserService(IUserRepository userRepository, SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public UserViewModel GetCurrentUser(string username)
        {
            try
            {
                User user = _userRepository.GetByUsername(username);
                return new UserViewModel
                {
                    Id = user.Id,
                    Username = user.UserName
                };
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }
        public void Login(LoginViewModel loginViewModel, out bool isAdmin)
        {
            User user = _userRepository.GetByUsername(loginViewModel.Username);
            var result = _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false).Result;

            isAdmin = false;
            if (result.Succeeded)
            {
                //always false
                isAdmin = _userManager.IsInRoleAsync(user, "admin").Result;
            }
            if (result.IsNotAllowed)
            {
                throw new Exception("Username or Password is not correct!");
            }
        }
        public void Register(RegisterViewModel registerViewModel)
        {
            User user = new User
            {
                UserName = registerViewModel.Username,
                Email = registerViewModel.Email,
                BirthDate = registerViewModel.Birthdate,
                Reservations = new List<Reservation>() { },
                Tickets = new List<Ticket>() { }
               
            };

            var password = registerViewModel.Password;

            var result = _userManager.CreateAsync(user, password).Result;

            bool isAdmin = false;
            if (result.Succeeded)
            {
                var currentUser = _userManager.FindByNameAsync(user.UserName).Result;
                var roleResult = _userManager.AddToRoleAsync(currentUser, "user").Result;
                if (roleResult.Succeeded)
                {
                    Login(new LoginViewModel
                    {
                        Username = registerViewModel.Username,
                        Password = registerViewModel.Password
                    }, out isAdmin);
                }
                else
                {
                    throw new Exception("Adding user to a role failed!");
                }
            }

        }
        public void Logout()
        {
            _signInManager.SignOutAsync();
        }

    }
}
