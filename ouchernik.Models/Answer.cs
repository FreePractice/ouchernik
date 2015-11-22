using System.Collections.Generic;

namespace ouchernik.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Answer
    {
        private ICollection<Vote> votes;

        public Answer()
        {
            this.votes = new HashSet<Vote>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }

        [Required]
        public string AuthorId { get; set; }

        public virtual User Author { get; set; }

        public virtual ICollection<Vote> Votes
        {
            get { return this.votes; }
            set { this.votes = value; }
        }
    }
}
 