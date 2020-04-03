using System;
using System.Collections.Generic;
using WeightAPI.Models;
using WeightAPI.Models.Constants;

namespace WeightAPI.Services
{
    public static class WeightDBContextExtensions
    {
        public static void CreateSeedData(this WeightDBContext context)
        {
            var exercises = new List<Exercise>()
            {
                new Exercise()
                {
                    ExerciseName = "Push-Up",
                    Custom = false,
                    BodyPart = BodyPart.Chest,
                    WorkoutType = WorkoutType.BodyWeigt,
                    Notes = "Typical Push-Up",
                    URL = "https://www.youtube.com/watch?v=_l3ySVKYVJ8"
                },
            };
        }
    }
}
