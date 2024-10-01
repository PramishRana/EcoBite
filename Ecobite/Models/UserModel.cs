using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Ecobite.Models
{
    public enum UserRole
    {
        Admin,
        Donor,
        Receiver,
        Volunteer
    }

    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength (100)]
        public required string UserName { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [DataType (DataType.Password)] 
        public required string Password { get; set; }

        [Phone]
        public required string Phonenumber { get; set; }

        [Required]
        [StringLength(100)]
        public string? Address { get; set; }

        [Required]
        public UserRole Role { get; set; }  
         



    }
}
