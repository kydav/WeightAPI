using System;
using System.Collections.Generic;
using System.Linq;
using WeightAPI.Contexts;
using WeightAPI.Entities;
using WeightAPI.Models;

namespace WeightAPI.Repositories
{
    public class ExerciseStepRepository : IExerciseStepRepository
    {
        private readonly WeightDBContext _context;

        public ExerciseStepRepository(WeightDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public ExerciseStep GetExerciseStep(int exerciseStepId)
        {
            return _context.ExerciseStep.Where(e => e.Id == exerciseStepId).FirstOrDefault();
        }
        public List<ExerciseStep> GetExerciseSteps(int exerciseId)
        {
            return _context.ExerciseStep.Where(e => e.ExerciseId == exerciseId).ToList() ;
        }

        public void AddExerciseStep(ExerciseStep exerciseStep)
        {
            _context.ExerciseStep.Add(exerciseStep);
            Save();
        }
        public void AddExerciseSteps(List<ExerciseStep> exerciseSteps)
        {
            foreach(var step in exerciseSteps)
            {
                _context.ExerciseStep.Add(step);
            }
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        
    }
}
