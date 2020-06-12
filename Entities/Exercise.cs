using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WeightAPI.Entities.Constants;

namespace WeightAPI.Entities
{
    public class Exercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string ExerciseName { get; set; }

        [Required]
        public bool Custom { get; set; }

        [Required]
        public BodyPart BodyPart { get; set; }

        [Required]
        public WorkoutType WorkoutType { get; set; }

        [Required]
        public Metric Metric { get; set; }

        public string Notes { get; set; }

        public string URL { get; set; }
    }
}