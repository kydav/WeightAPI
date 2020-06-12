using System;
using System.Collections.Generic;
using WeightAPI.Models;
using WeightAPI.Models.Constants;

namespace WeightAPI.Contexts
{
    public static class WeightDBContextExtensions
    {
        public static void CreateSeedData(this WeightDBContext context)
        {
            var users = new List<User>
            {
                new User()
                {
                    FirstName = "Kyler",
                    LastName = "Davis",
                    EmailAddress = "ky.s.dav@gmail.com",
                    Password = "password"
                }
            };
            var exercises = new List<Exercise>()
            {

                new Exercise()
                {
                    Id = 1,
                    ExerciseName = "Bench Press",
                    Custom = false,
                    BodyPart = BodyPart.Chest,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Id = 2,
                    ExerciseName = "Incline Bench Press",
                    Custom = false,
                    BodyPart = BodyPart.Chest,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Id = 3,
                    ExerciseName = "Incline Chest Fly",
                    Custom = false,
                    BodyPart = BodyPart.Chest,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Id = 4,
                    ExerciseName = "Chest Fly",
                    Custom = false,
                    BodyPart = BodyPart.Chest,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Id = 5,
                    ExerciseName = "Tricep Pushdown(Bar)",
                    Custom = false,
                    BodyPart = BodyPart.Arms,
                    WorkoutType = WorkoutType.Cable,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Id = 6,
                    ExerciseName = "Skullcrusher",
                    Custom = false,
                    BodyPart = BodyPart.Arms,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Id = 7,
                    ExerciseName = "Overhead Tricep Extension",
                    Custom = false,
                    BodyPart = BodyPart.Arms,
                    WorkoutType = WorkoutType.Cable,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Id = 8,
                    ExerciseName = "Standing Calf Raise",
                    Custom = false,
                    BodyPart = BodyPart.Legs,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Seated Calf Raise",
                    Custom = false,
                    BodyPart = BodyPart.Legs,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "One Arm Bent Over Row",
                    Custom = false,
                    BodyPart = BodyPart.Back,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Lateral Pulldown",
                    Custom = false,
                    BodyPart = BodyPart.Back,
                    WorkoutType = WorkoutType.Cable,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Standing Pulldown",
                    Custom = false,
                    BodyPart = BodyPart.Back,
                    WorkoutType = WorkoutType.Cable,
                    Notes = "Performed with wide grip cable attachment, lean back, and pull bar into chest.",
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Bicep Curl",
                    Custom = false,
                    BodyPart = BodyPart.Arms,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Incline Dumbbell Curl",
                    Custom = false,
                    BodyPart = BodyPart.Arms,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Flat Bench Lying Curl",
                    Custom = false,
                    BodyPart = BodyPart.Arms,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Hanging Leg Raise",
                    Custom = false,
                    BodyPart = BodyPart.Core,
                    WorkoutType = WorkoutType.Bodyweight,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Crunch",
                    Custom = false,
                    BodyPart = BodyPart.Core,
                    WorkoutType = WorkoutType.Bodyweight,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Side Bend",
                    Custom = false,
                    BodyPart = BodyPart.Core,
                    WorkoutType = WorkoutType.Dumbbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "OverheadPress",
                    Custom = false,
                    BodyPart = BodyPart.Shoulders,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Lateral Raise",
                    Custom = false,
                    BodyPart = BodyPart.Shoulders,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "One Arm Front Raise",
                    Custom = false,
                    BodyPart = BodyPart.Shoulders,
                    WorkoutType = WorkoutType.Cable,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Seated Bent Over Rear Delt Fly",
                    Custom = false,
                    BodyPart = BodyPart.Back,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Shrug",
                    Custom = false,
                    BodyPart = BodyPart.Shoulders,
                    WorkoutType = WorkoutType.Dumbbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Squat",
                    Custom = false,
                    BodyPart = BodyPart.Legs,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "One Legged Squat",
                    Custom = false,
                    BodyPart = BodyPart.Legs,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Lunge",
                    Custom = false,
                    BodyPart = BodyPart.Legs,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Romanian Deadlift",
                    Custom = false,
                    BodyPart = BodyPart.Legs,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Good Morning",
                    Custom = false,
                    BodyPart = BodyPart.Legs,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    ExerciseName = "Side Plank",
                    Custom = false,
                    BodyPart = BodyPart.Core,
                    WorkoutType = WorkoutType.Bodyweight,
                    Metric = Metric.Time
                }
            };
            

        }
    }
}
