using System;
using System.ComponentModel.DataAnnotations;
namespace Club.Models.Account
{
    public class login
    {
        public login()
        {
            
        }
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
