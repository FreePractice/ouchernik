namespace ouchernik.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Resource
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        /// <summary>
        ///     Extensions: doc, docx, pdf, xls, jpg, jpeg, png, ppt, zip
        /// </summary>
        [Required]
        public string Extension { get; set; }

        /// <summary>
        ///     in Mbs
        /// </summary>
        [Required]
        public float Size { get; set; }

        [Required]
        public string Path { get; set; }

        [Required]
        public DateTime UploadedOn { get; set; }
    }
}
