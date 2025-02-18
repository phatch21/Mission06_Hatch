using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Hatch.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Director { get; set; }

        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be 1888 or later.")]
        public int Year { get; set; }


        [Required]
        public string? Rating { get; set; }

        [Required]
        public int CategoryId { get; set; } // ✅ Added CategoryId

        [NotMapped] // Maps integer values as boolean
        public bool EditedBool
        {
            get => Edited == 1;
            set => Edited = value ? 1 : 0;
        }
        public int Edited { get; set; }

        public string? LentTo { get; set; }

        [NotMapped]
        public bool CopiedToPlexBool
        {
            get => CopiedToPlex == 1;
            set => CopiedToPlex = value ? 1 : 0;
        }
        public int CopiedToPlex { get; set; }

        public string? Notes { get; set; }
    }
}
