using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WeightAPI.Models.Constants;

namespace WeightAPI.Models
{
    public class CustomExercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ExerciseName { get; set; }

        [Required]
        public bool Custom { get; set; }

        [Required]
        public BodyPart BodyPart { get; set; }

        [Required]
        public WorkoutType WorkoutType { get; set; }

        [Required]
        public Metric Metric { get; set; }

        [MaxLength(200)]
        public string Notes { get; set; }

        [MaxLength(200)]
        public string URL { get; set; }
    }
}