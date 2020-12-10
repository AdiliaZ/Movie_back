using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
 using Microsoft.AspNetCore.Http;
using Movie_Back.Models;
using Movie_back.Repository;


namespace Movie_back.Pages
{
    public class Sign_inModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public User Password { get; set; }
        public string Msg;
        public void OnGet()
        {
        }
        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("email");
            return Page();
        }
        public IActionResult OnPost()
         {
            if (Email.Equals("") &&  Password.Equals("def"))
            {
                HttpContext.Session.SetString("email", Email);
                return RedirectToPage("/User_page");
            }
            else
            {
                Msg = "Invalid";
                return Page();
            }

        }
      /*  public async Task<IActionResult> OnPostSignIn()
        {
            var UserRep = HttpContext.RequestServices.GetService<IUserRepository>();
            var Email = (string)HttpContext.Request.Form["email"];
            var Password = (string)HttpContext.Request.Form["password"];
            var Remember = (string)HttpContext.Request.Form["rememberMe"];

            var user = await .GetUser(Email, Password);

   

            if (Remember == "on")
            {
                SetCookie(user.Key);
            }
            HttpContext.Session.Set("user", user);
            return Redirect("/Index");

        }*/
    }
}
