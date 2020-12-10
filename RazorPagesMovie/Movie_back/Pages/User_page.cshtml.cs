using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movie_back.Repository;
using Microsoft.AspNetCore.Http;

namespace Movie_back.Pages
{
    public class User_pageModel : PageModel
    {
        public string Email { get; set; }
        private readonly IUserRepository _db;
        public User_pageModel(IUserRepository db)
        {
            _db = db;
        }
 
        public void OnGet()
        {
           Email = HttpContext.Session.GetString("email");
        }
    }
}
