namespace ouchernik.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Vote
    {
        [Key]
        public int Id { get; set; }

        public int? AnswerId { get; set; }

        public virtual Answer Answer { get; set; }

        [Required]
        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
