using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.Services.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterViewModel registerViewModel);

        void Login(LoginViewModel loginViewModel, out bool isAdmin);

        void Logout();

        UserViewModel GetCurrentUser(string username);
    }
}
