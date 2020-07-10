using System;
using System.Collections.Generic;
using System.Linq;
using WeightAPI.Contexts;
using WeightAPI.Entities;
using WeightAPI.Models;

namespace WeightAPI.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly WeightDBContext _context;

        public ExerciseRepository(WeightDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Exercise GetExercise(int exerciseId)
        {
            var exercise = _context.Exercise.Where(e => e.Id == exerciseId).FirstOrDefault();
            var steps = _context.ExerciseStep.Where(e => e.ExerciseId == exerciseId).ToList();
            exercise.Steps = steps;
            return exercise;
        }
        public List<Exercise> GetExercises()
        {
            return _context.Exercise.ToList();
        }

        public void AddExercise(Exercise exercise)
        {
            _context.Exercise.Add(exercise);
            if (exercise.Steps.Count > 0)
            {
                foreach (var step in exercise.Steps)
                {
                    _context.ExerciseStep.Add(step);
                }
            }
        }

        public void DeleteExercise(Exercise exercise)
        {
            _context.Exercise.Remove(exercise);
        }

        public bool ExerciseExists(int exerciseId)
        {
            return _context.Exercise.Any(e => e.Id == exerciseId);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        
    }
}
