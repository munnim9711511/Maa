using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using coouncil.Models;
using Coun.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Coun.Controllers {
    public class AccountController : Controller {
        private readonly SignInManager<IdentityUser> _siginManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController (SignInManager<IdentityUser> _siginManager,
            UserManager<IdentityUser> _userManager,
            RoleManager<IdentityRole> _roleManager) {
            this._userManager = _userManager;
            this._siginManager = _siginManager;
            this._roleManager = _roleManager;
        }

        [HttpGet]
        public IActionResult Login () {
            return View ();
        }

        [HttpPost]
        public async Task<IActionResult> Register (UserModel usr) {

            var user = new IdentityUser {
                UserName = usr.UserName
            };
            var result = await _userManager.CreateAsync (user, usr.Password);

            return RedirectToAction("Users","Admin");
        }

        [HttpGet]
        public async Task<IActionResult> RegisterAdmin () {
            // first we create Admin rool
            dynamic role = new IdentityRole ();
            role.Name = "Administrator";
            await _roleManager.CreateAsync (role);

            var user = new IdentityUser {
                UserName = "admin"
            };
            // return Content ("user created");
            var result = await _userManager.CreateAsync (user, "Hellow@1234@M");
            //Here we create a Admin super user who will maintain the website    
            if (result.Succeeded) {
                var result1 = await _userManager.AddToRoleAsync (user, "Administrator");
            }

            return Content ("user created");
        }

        [HttpGet]
        public IActionResult Logout () {
            var result = _siginManager.SignOutAsync ();
            return RedirectToAction ("Login", "Account");
        }

      
        [HttpPost]
        public async Task<IActionResult> Login (UserModel user) {
            var result = await _siginManager.PasswordSignInAsync (user.UserName, user.Password, user.RememberMe, false);
            if (!result.Succeeded) {
                return RedirectToAction ("Login", "Account");
            }

            return RedirectToAction ("Index", "Admin");
            // return Json(user);
        }

    }
}