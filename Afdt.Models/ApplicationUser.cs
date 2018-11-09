using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Afdt.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }


}
