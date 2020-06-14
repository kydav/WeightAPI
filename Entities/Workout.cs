using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeightAPI.Entities
{
    public class Workout
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public List<WorkoutExercise> Exercises { get; set; }

        public string Notes { get; set; }

        [Required]
        public System.DateTime DatePerformed { get; set; }
    }
}