using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeightAPI.Models
{
    public class ExerciseSet
    {
        public int Id { get; set; }

        public int Repetitions { get; set; }

        public int Weight { get; set; }
    }
}