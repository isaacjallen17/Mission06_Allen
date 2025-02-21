using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Allen.Models
{
    public class Movie
    {

        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Must input a title.")]
        public string Title { get; set; }

        [Range(1888, 2025, ErrorMessage = "Year input must be between 1888 and 2025.")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required]
        public bool Edited { get; set; } = false;

        public string? LentTo { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; } = false;

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
