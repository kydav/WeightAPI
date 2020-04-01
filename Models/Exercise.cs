using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WeightAPI.Models.Constants;

namespace WeightAPI.Models
{
    public class Exercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string ExerciseName { get; set; }

        [Required]
        public BodyPart Part { get; set; }

        [Required]
        public WorkoutType Type { get; set; }

        public string Notes { get; set; }

        public string URL { get; set; }
    }
}