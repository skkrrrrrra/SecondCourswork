using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Courswork.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Pasword { get; set; }
    public string Email { get; set; }
}

