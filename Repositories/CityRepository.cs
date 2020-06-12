using System;
using System.Linq;
using WeightAPI.Contexts;
using WeightAPI.Entities;
using WeightAPI.Models;

namespace WeightAPI.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly WeightDBContext _context;
        public CityRepository(WeightDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Exercise GetExercise(int exerciseId)
        {
            return _context.Exercises.Where(e => e.Id == exerciseId).FirstOrDefault();
        }

        public void AddExercise(Exercise exercise)
        {
            _context.Exercises.Add(exercise);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
