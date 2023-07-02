using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.Azure.Documents;

namespace BugTrackerWeb.Models
{
    public class Category
    {

       
        [Key]
        public int Id { get; set; }
        [MaxLength(100, ErrorMessage = "Title can only be upto 100 characters")]
        [Required]
        public string Title { get; set; }
        [Required]
        public string Issue { get; set; }
        public string Solution { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        [EmailAddress]
        public string User { get; set; }
    }
}
