using Microsoft.AspNetCore.Mvc;
using SEAVUS.Movie.Services.Interfaces;
using SEAVUS.Movie.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEAVUS.Movie.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult LogIn()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult LogIn(LoginViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isAdmin;
                    _userService.Login(model, out isAdmin);
                    // this does not work isAdmin is always false
                    if (isAdmin)
                    {
                        return RedirectToAction("index", "home");
                    }
                    else
                    {
                        return RedirectToAction("index", "home");
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
            return View(model);
        }

        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _userService.Register(model);
                    return RedirectToAction("index", "home");
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;

                ViewBag.Message = message;

                return RedirectToAction("Error", "Home");
            }

            return View(model);
        }

        public IActionResult LogOut()
        {
            _userService.Logout();
            return RedirectToAction("index", "home");
        }

    }
}
