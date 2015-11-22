namespace ouchernik.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using System;

    public class Question
    {
        private ICollection<Answer> answers;
        private ICollection<Vote> votes;

        public Question()
        {
            this.answers = new HashSet<Answer>();
            this.votes = new HashSet<Vote>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string AuthorId { get; set; }

        public virtual User Author { get; set; }

        public virtual ICollection<Answer> Answers
        {
            get { return this.answers; }
            set { this.answers = value; }
        }

        public virtual ICollection<Vote> Votes
        {
            get { return this.votes; }
            set { this.votes = value; }
        }
    }
}
