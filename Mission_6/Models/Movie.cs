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

        public int CategoryId { get; set; }
        public string? Title { get; set; }
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }

        [NotMapped]
        public bool EditedBool
        {
            get => Edited == 1;
            set => Edited = value ? 1 : 0;
        }

        public int Edited { get; set; } // Stores 0 or 1 in the database

        public string? LentTo { get; set; }

        [NotMapped]
        public bool CopiedToPlexBool
        {
            get => CopiedToPlex == 1;
            set => CopiedToPlex = value ? 1 : 0;
        }

        public int CopiedToPlex { get; set; } // Stores 0 or 1 in the database

        public string? Notes { get; set; }
    }
}
