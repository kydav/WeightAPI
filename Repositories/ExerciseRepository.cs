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
            return _context.Exercise.Where(e => e.Id == exerciseId).FirstOrDefault();
        }
        public List<Exercise> GetExercises()
        {
            return _context.Exercise.ToList();
        }

        public void AddExercise(Exercise exercise)
        {
            _context.Exercise.Add(exercise);
            if (exercise.Steps.Count > 0)
                foreach (var step in exercise.Steps)
                    _context.ExerciseStep.Add(step);


        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        
    }
}
