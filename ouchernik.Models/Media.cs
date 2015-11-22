namespace ouchernik.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Media
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        [Required]
        public string Path { get; set; }

        [Required]
        public string Extension { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int? NewsId { get; set; }

        public virtual News News { get; set; }
    }
}
