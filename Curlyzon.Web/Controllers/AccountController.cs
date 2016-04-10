using Curlyzon.Repository.Contracts;
using Curlyzon.Web.Common;
using Curlyzon.Web.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Curlyzon.Web.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IUserRepository _UserRepository;

        public AccountController(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        //
        // GET: /Account/Login
        public ActionResult Login(string returnUrl, LoginViewModel model)
        {
            ViewBag.ReturnUrl = returnUrl;
            foreach (var key in ModelState.Keys.ToList().Where(key => ModelState.ContainsKey(key)))
            {
                ModelState[key].Errors.Clear();
            }
            return View(model);
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                string userId = _UserRepository.Login(model.UserName, model.Password);
                if (!String.IsNullOrEmpty(userId))
                {
                    Session["UserId"] = userId;
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            ModelState.AddModelError("", "Incorrect user name or password.");
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
            return RedirectToAction("Index", "Home");
        }

    }
}