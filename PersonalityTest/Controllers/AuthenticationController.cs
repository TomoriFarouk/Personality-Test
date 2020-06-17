using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalityTest.Models;
using PersonalityTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalityTest.Controllers
{
	public class AuthenticationController:Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly ILogger<AuthenticationController> _logger;

		public AuthenticationController(
		   UserManager<ApplicationUser> userManager,
		   SignInManager<ApplicationUser> signInManager,
			 ILoggerFactory loggerFactory, RoleManager<IdentityRole> roleManager)
			// ILogger<HomeController> logger,
			
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_logger = loggerFactory.CreateLogger<AuthenticationController>();
		}

		#region Helpers
		public IActionResult Index()
		{
			return View();
		}
		private void AddErrors(IdentityResult result)
		{
			foreach (var error in result.Errors)
			{
				ModelState.AddModelError(string.Empty, error.Description);
			}
		}

		private IActionResult RedirectToLocal(string returnUrl)
		{
			if (Url.IsLocalUrl(returnUrl))
			{
				return Redirect(returnUrl);
			}
			else
			{
				return RedirectToAction(nameof(AuthenticationController.Index), "Identity");
			}
		}

		#endregion

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Register(string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			return View();
		}


		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Register([FromForm]RegisterViewModel fi_RegInfo, string returnUrl = null)
		// public async Task<IActionResult> Register(RegisterViewModel fi_RegInfo, string returnUrl = null) also works
		{
			ViewData["ReturnUrl"] = returnUrl;
			if (ModelState.IsValid)
			{
				var user = new ApplicationUser() { lastName = fi_RegInfo.LastNames, FirstName = fi_RegInfo.FirstNames, UserName = fi_RegInfo.usernames, Email = fi_RegInfo.Email, Address = fi_RegInfo.HomeAddress, PasswordHash = fi_RegInfo.Password, PhoneNumber = fi_RegInfo.PhoneNumber, Dob = fi_RegInfo.Dob };
				var result = await _userManager.CreateAsync(user, fi_RegInfo.Password);
				if (result.Succeeded)
				{
					// if (!await RoleManager.RoleExistsAsync("Admin"))
					//{

					//     var users = new IdentityRole("Admin");     //    was used to create role admin, later was deleted and 
					//   var response = await RoleManager.CreateAsync(users); // admin below  was also changed to user so it became
					//    if (response.Succeeded)      //  ( user, "User") not (user, "Admin") anymore.
					//  {
					
					_logger.LogInformation(" Account Created");
					await _signInManager.SignInAsync(user, isPersistent: false);
					_logger.LogInformation("User created a new account with password.");

					// }
					return RedirectToAction("Login", "Authentication");

				}
				else
					AddErrors(result);
				// }
				// If we got this far, something failed, redisplay form
			}
			return View(fi_RegInfo);

		}

		[HttpGet]
		[AllowAnonymous]
		public async Task<IActionResult> Login(string returnUrl = null)
		{
			// Clear the existing external cookie to ensure a clean login process
			await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

			ViewData["ReturnUrl"] = returnUrl;
			return View();
		}

		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(LoginViewModel fi_LoginInfo, string returnUrl = null)


		{
			ViewData["ReturnUrl"] = returnUrl;
			if (ModelState.IsValid)
			{
				// This doesn't count login failures towards account lockout
				// To enable password failures to trigger account lockout, set lockoutOnFailure: true
				var result = await _signInManager.PasswordSignInAsync(fi_LoginInfo.UserName, fi_LoginInfo.Password, fi_LoginInfo.RememberMe, lockoutOnFailure: false);
				if (result.Succeeded)
				{
					_logger.LogInformation("User logged in.");
					

					return RedirectToAction("Index", "Question");
				}
				if (result.IsLockedOut)
				{
					_logger.LogWarning("User account locked out.");
					return RedirectToAction(nameof(Lockout));
				}
				else
				{
					ModelState.AddModelError(string.Empty, "Invalid login attempt.");
					return View(fi_LoginInfo);
				}
			}

			// If we got this far, something failed, redisplay form
			return View(fi_LoginInfo);
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Lockout()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			_logger.LogInformation("User logged out.");
			return RedirectToAction(nameof(HomeController.Index), "Home");
		}

		[HttpGet]
		[Authorize]
		public IActionResult GetProtectedData()
		{
			return Json(new { ProtectedData = "protected data" });
		}
	}
}
