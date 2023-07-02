using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BugTrackerWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DbSet<Category>? Categories { get; set; }

    }
}
