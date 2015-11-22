using System.Collections.Generic;

namespace ouchernik.Models
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        private ICollection<Vote> votes { get; set; }
        private ICollection<Question> questions { get; set; }
        private ICollection<Answer> answers { get; set; }
        private ICollection<SchoolSubject> schoolSubjects { get; set; }

        public User()
        {
            this.votes = new HashSet<Vote>();
            this.questions = new HashSet<Question>();
            this.answers = new HashSet<Answer>();
            this.schoolSubjects = new HashSet<SchoolSubject>();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Birthdate { get; set; }

        public int? MediaId { get; set; }

        public virtual Media Media { get; set; }

        public virtual ICollection<Vote> Votes
        {
            get { return this.votes; }
            set { this.votes  = value; }
        }

        public virtual ICollection<Question> Questions
        {
            get { return this.questions; }
            set { this.questions = value; }
        }

        public virtual ICollection<Answer> Answers
        {
            get { return this.answers; }
            set { this.answers = value; }
        }

        public virtual ICollection<SchoolSubject> SchoolSubjects
        {
            get { return this.schoolSubjects; }
            set { this.schoolSubjects = value; }
        }

        public int? SchoolClassId { get; set; }

        public virtual SchoolClass SchoolClass { get; set; }

        public Gender Gender { get; set; }
    }
}
