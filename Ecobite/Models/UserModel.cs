namespace Ecobite.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public required string UserName { get; set; }

        public required string Password { get; set; }

        public required string Email { get; set; }

        public required string Phone { get; set; }
         


    }
}
