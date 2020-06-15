using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WeightAPI.Entities;
using WeightAPI.Models;

namespace WeightAPI.Contexts
{
    public class WeightDBContext : DbContext
    {
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseStep> ExerciseSteps { get; set; }
        //public DbSet<ExerciseSet> ExerciseSets { get; set; }
        //public DbSet<Routine> Routines { get; set; }
        //public DbSet<RoutineExercise> RoutineExercises { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Workout> Workouts { get; set; }
        //public DbSet<WorkoutExercise> WorkoutExercises { get; set; }

        public WeightDBContext(DbContextOptions<WeightDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }


    }
}