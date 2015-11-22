namespace ouchernik.Models
{
    using System.ComponentModel.DataAnnotations;
    using System;
    using System.Collections.Generic;

    public class News
    {
        private ICollection<Media> media;

        public News()
        {
            this.media = new HashSet<Media>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public int Views { get; set; }

        [Required]
        public int RubricId { get; set; }

        public virtual Rubric Rubric { get; set; }

        public virtual ICollection<Media> Media
        {
            get { return this.media; }
            set { this.media = value; }
        }
    }
}
