using System.Collections.Generic;
using WeightAPI.Constants;

namespace WeightAPI.Models
{
    public class ExerciseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<ExerciseStepDto> Steps { get; set; }

        public bool Custom { get; set; }

        public BodyPart BodyPart { get; set; }

        public WorkoutType WorkoutType { get; set; }

        public Metric Metric { get; set; }

        public string URL { get; set; }
    }
}
