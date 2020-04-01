using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeightAPI.Models
{
    public class RoutineExercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Exercise Exercise { get; set; }

        public List<ExerciseSet> Sets { get; set; }
        
        [Required]
        public int RestPeriod { get; set; }

    }
}