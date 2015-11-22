using System.Collections.Generic;

namespace ouchernik.Models
{
    using System.ComponentModel.DataAnnotations;

    public class SchoolClass
    {
        private ICollection<User> users;

        public SchoolClass()
        {
            this.users = new HashSet<User>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> Users
        {
            get {return  this.users; }
            set { this.users = value; } 
        }
    }
}
