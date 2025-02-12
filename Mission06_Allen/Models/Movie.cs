using System.ComponentModel.DataAnnotations;

namespace Mission06_Allen.Models
{
    public class Movie
    {

        [Key]
        [Required]
        public int MovieId { get; set; }

        public string Category { get; set; }

        public string Title { get; set; }

        [Range(1865, 2025)]
        public int Year { get; set; }

        public string Director { get; set; }

        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent { get; set; }

        public string Notes { get; set; }

    }
}
