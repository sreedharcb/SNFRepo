using System;
using System.Collections.Generic;

namespace AuthAPI.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string Userlogin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? Mobilenumber { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public Roles RoleNavigation { get; set; }
    }
}
