using Final_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Final_Project.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace Final_Project.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel newUser)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser userModel = new ApplicationUser();
                userModel.UserName = newUser.UserName;
                userModel.PasswordHash = newUser.Password;

                IdentityResult result = await _userManager.CreateAsync(userModel,newUser.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(userModel, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(newUser);
        }
        [AllowAnonymous]

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel userVm)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser userModel=await _userManager.FindByNameAsync(userVm.UserName);
                if (userModel != null)
                {
                   bool found=await _userManager.CheckPasswordAsync(userModel, userVm.Password);
                    if (found)
                    {
                        await _signInManager.SignInAsync(userModel, userVm.RememberMe);
                        return RedirectToAction("ShowAllServices", "Task");
                    }
                }
                    ModelState.AddModelError("","Login Failed");
 
            }
            return View(userVm);
        }
        public async Task< IActionResult > SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }


}
