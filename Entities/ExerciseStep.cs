using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeightAPI.Entities
{
    public class ExerciseStep
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [ForeignKey("ExerciseId")]
        public Exercise Exercise { get; set; }

        [Required]
        public int ExerciseId { get; set; }

        [Required]
        public int StepNumber { get; set; }

        [Required]
        public string StepWording { get; set; }
    }
}
