using System;
using System.Collections.Generic;

namespace AuthAPI.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Users = new HashSet<Users>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
