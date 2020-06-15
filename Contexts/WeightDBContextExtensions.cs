using System;
using System.Collections.Generic;
using WeightAPI.Models;
using WeightAPI.Entities;
using WeightAPI.Constants;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WeightAPI.Contexts
{
    public static class WeightDBContextExtensions
    {
        public static void CreateSeedData(this WeightDBContext context)
        {
            if (context.Exercise.Any())
                return;

            
            //var users = new List<User>
            //{
            //    new User()
            //    {
            //        FirstName = "Kyler",
            //        LastName = "Davis",
            //        EmailAddress = "ky.s.dav@gmail.com",
            //        Password = "password"
            //    }
            //};
            var exercises = new List<Exercise>()
            {

                new Exercise()
                {
                    //Id = 1,
                    Name = "Bench Press",
                    Steps = new List<ExerciseStep>()
                    {
                        new ExerciseStep()
                        {
                            StepNumber = 1,
                            StepWording = "Lay on flat bench with barbell within arms reach above"
                        },
                        new ExerciseStep()
                        {
                            StepNumber = 2,
                            StepWording = "Unrack barbell"
                        },
                        new ExerciseStep()
                        {
                            StepNumber = 3,
                            StepWording = "Depress barbell down to chest"
                        },
                        new ExerciseStep()
                        {
                            StepNumber = 4,
                            StepWording = "Press barbell back up extending arms"
                        },
                        new ExerciseStep()
                        {
                            StepNumber = 5,
                            StepWording = "Repeat for repetitions and rack weight when done"
                        }
                    },
                    Custom = false,
                    BodyPart = BodyPart.Chest,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    //Id = 2,
                    Name = "Incline Bench Press",
                    Custom = false,
                    BodyPart = BodyPart.Chest,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    //Id = 3,
                    Name = "Incline Chest Fly",
                    Custom = false,
                    BodyPart = BodyPart.Chest,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    //Id = 4,
                    Name = "Chest Fly",
                    Custom = false,
                    BodyPart = BodyPart.Chest,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    //Id = 5,
                    Name = "Tricep Pushdown(Bar)",
                    Custom = false,
                    BodyPart = BodyPart.Arms,
                    WorkoutType = WorkoutType.Cable,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    //Id = 6,
                    Name = "Skullcrusher",
                    Custom = false,
                    BodyPart = BodyPart.Arms,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    //Id = 7,
                    Name = "Overhead Tricep Extension",
                    Custom = false,
                    BodyPart = BodyPart.Arms,
                    WorkoutType = WorkoutType.Cable,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    //Id = 8,
                    Name = "Standing Calf Raise",
                    Custom = false,
                    BodyPart = BodyPart.Legs,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Seated Calf Raise",
                    Custom = false,
                    BodyPart = BodyPart.Legs,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "One Arm Bent Over Row",
                    Custom = false,
                    BodyPart = BodyPart.Back,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Lateral Pulldown",
                    Custom = false,
                    BodyPart = BodyPart.Back,
                    WorkoutType = WorkoutType.Cable,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Standing Pulldown",
                    Custom = false,
                    BodyPart = BodyPart.Back,
                    WorkoutType = WorkoutType.Cable,
                    Notes = "Performed with wide grip cable attachment, lean back, and pull bar into chest.",
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Bicep Curl",
                    Custom = false,
                    BodyPart = BodyPart.Arms,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Incline Dumbbell Curl",
                    Custom = false,
                    BodyPart = BodyPart.Arms,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Flat Bench Lying Curl",
                    Custom = false,
                    BodyPart = BodyPart.Arms,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Hanging Leg Raise",
                    Custom = false,
                    BodyPart = BodyPart.Core,
                    WorkoutType = WorkoutType.Bodyweight,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Crunch",
                    Custom = false,
                    BodyPart = BodyPart.Core,
                    WorkoutType = WorkoutType.Bodyweight,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Side Bend",
                    Custom = false,
                    BodyPart = BodyPart.Core,
                    WorkoutType = WorkoutType.Dumbbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "OverheadPress",
                    Custom = false,
                    BodyPart = BodyPart.Shoulders,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Lateral Raise",
                    Custom = false,
                    BodyPart = BodyPart.Shoulders,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "One Arm Front Raise",
                    Custom = false,
                    BodyPart = BodyPart.Shoulders,
                    WorkoutType = WorkoutType.Cable,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Seated Bent Over Rear Delt Fly",
                    Custom = false,
                    BodyPart = BodyPart.Back,
                    WorkoutType = WorkoutType.Dumbbells,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Shrug",
                    Custom = false,
                    BodyPart = BodyPart.Shoulders,
                    WorkoutType = WorkoutType.Dumbbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Squat",
                    Custom = false,
                    BodyPart = BodyPart.Legs,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "One Legged Squat",
                    Custom = false,
                    BodyPart = BodyPart.Legs,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Lunge",
                    Custom = false,
                    BodyPart = BodyPart.Legs,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Romanian Deadlift",
                    Custom = false,
                    BodyPart = BodyPart.Legs,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Good Morning",
                    Custom = false,
                    BodyPart = BodyPart.Legs,
                    WorkoutType = WorkoutType.Barbell,
                    Metric = Metric.Weight
                },
                new Exercise()
                {
                    Name = "Side Plank",
                    Custom = false,
                    BodyPart = BodyPart.Core,
                    WorkoutType = WorkoutType.Bodyweight,
                    Metric = Metric.Time
                }
            };
            context.AddRange(exercises);
            context.SaveChanges();

        }
    }
}
