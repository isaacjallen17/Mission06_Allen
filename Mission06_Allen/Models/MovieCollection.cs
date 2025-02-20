using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Mission06_Allen.Models
{
    public class MovieCollection
    {

        [Key]
        [Required]
        public int MovieId { get; set; }

        public string Category { get; set; }

        public string Title { get; set; }

        [Range(1888, 2025)]
        public int Year { get; set; }

        public string Director { get; set; }

        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string? Lent { get; set; } = string.Empty;

        public string? Notes { get; set; } = string.Empty;

    }
}
