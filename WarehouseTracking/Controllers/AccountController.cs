using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.AppUserDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WarehouseTracking.Controllers
{
    public class AccountController : BaseController
    {

        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager, IMapper mapper, SignInManager<AppUser> signInManager) : base(userManager, mapper)
        {
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(AppUserLoginDto p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, true, false);
                if (result.Succeeded)
                {
                    //var roles = await UserManager.GetRolesAsync(UserManager.GetUserAsync(HttpContext.User).Result);
                    //if(roles.Count > 0)
                    return RedirectToAction("Index", "Home");
                    //else
                    //    return RedirectToAction("AccesDenied", "Account");
                }
                else
                    ModelState.AddModelError("", "Kullanıcı adı ya da şifre yanlış");
            }
            return View();
        }
        public IActionResult Register()
        {
            return View(new AppUserRegisterDto());
        }
        [HttpPost]
        public async Task<IActionResult> Register(AppUserRegisterDto p)
        {
            var user = Mapper.Map<AppUser>(p);
            var result = await UserManager.CreateAsync(user, p.Password);
            if (result.Succeeded)
            {
                var roleResult = await UserManager.AddToRoleAsync(user, "User");
                return RedirectToAction("Login");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(p);
            }

        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        public IActionResult Settings()
        {
            return View(LoggedInUser);
        }
        [HttpPost]
        public async Task<IActionResult> Settings(AppUser p)
        {
            bool usernameChanged = false;
            var user = await UserManager.FindByIdAsync(LoggedInUser.Id.ToString());
            user.FirstName = p.FirstName;
            user.LastName = p.LastName;          
            user.Email = p.Email;   
            user.CardId = p.CardId;
            if (user.UserName != p.UserName)
                usernameChanged = true;
            user.UserName = p.UserName; 
            var result = await UserManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                if (usernameChanged)
                {
                    await _signInManager.SignOutAsync();
                    return RedirectToAction("Login");
                }
                else
                    return View(p);
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(p);
            }            
        }
        [HttpPost]
        public async Task<JsonResult> ResetPassword(string UserName)
        {
            var user = await UserManager.FindByNameAsync(UserName);
            if (user == null)
                return Json(false);
            user.PasswordHash = UserManager.PasswordHasher.HashPassword(user,"12345678");
            var result = await UserManager.UpdateAsync(user);           
            if (result.Succeeded)            
                return Json(true);            
            else
                return Json(result.Errors);
        }
        [HttpPost]
        public async Task<JsonResult> ChangePassword(string NewPassword, string OldPassword)
        {
            var result = await UserManager.ChangePasswordAsync(LoggedInUser, OldPassword, NewPassword);
            if (result.Succeeded)
                return Json(true);
            else
                return Json(result.Errors);
        }
    }
}
