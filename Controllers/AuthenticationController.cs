using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AuthenticationController: Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        private readonly RoleManager<IdentityRole> _roleManager;
        public AuthenticationController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email

                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var role = await _roleManager.FindByNameAsync("Admin");
                    if (role == null)
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Admin"));
                    }
                    
                    //add role here
                    await _userManager.AddToRoleAsync(user, "Admin");
                    return RedirectToAction("Register", "Authentication");
                }
            }
            //
            ModelState.AddModelError("", "Account is exits.");
            return View(model);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(model.Email);
                    //user role list here
                    var roles = await _userManager.GetRolesAsync(user);
                    //get default role here
                    string role = roles.FirstOrDefault();
                    if (role.Equals("Admin"))
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else if (role.Equals("User"))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        //do something here. put in your logic 
                    }
                }
            }
            ModelState.AddModelError("", "Invalid ID or Password");
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
          await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Authentication");
        }

    }
}
