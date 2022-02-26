using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Custom_User_Management.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required,MaxLength(100)]
        public string firstName { get; set; }
        [Required, MaxLength(100)]
        public string lastName { get; set; }
        public byte[] profilePicture { get; set; }

    }
}
