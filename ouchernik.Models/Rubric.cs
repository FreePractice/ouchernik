namespace ouchernik.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Rubric
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
