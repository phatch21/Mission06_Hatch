// Payton Hatch
// Group 4-6

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Hatch.Models
{
    [Table("Movies")]
    public class Movie
    {
        // primary key in DB
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }

        // movie title
        [Required]
        public string Title { get; set; }

        // movie director
        public string? Director { get; set; }

        // movie year
        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be 1888 or later.")]
        public int Year { get; set; }

        // movie rating
        [Required]
        public string? Rating { get; set; }

        // movie category
        [Required]
        public int CategoryId { get; set; } // ✅ Added CategoryId

        // whether or not the record has been edited
        [NotMapped] // Maps integer values as boolean
        public bool EditedBool
        {
            // interprets the int in database as a boolean for yes or no
            get => Edited == 1;
            set => Edited = value ? 1 : 0;
        }
        public int Edited { get; set; }

        // to whom the movie is currently lent to
        public string? LentTo { get; set; }

        // whether or not the movie has been copied to plex
        [NotMapped]
        public bool CopiedToPlexBool
        {
            // interprets the int in database as a boolean for yes or no
            get => CopiedToPlex == 1;
            set => CopiedToPlex = value ? 1 : 0;
        }
        public int CopiedToPlex { get; set; }

        // additional notes
        public string? Notes { get; set; }
    }
}
