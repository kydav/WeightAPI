using System;
using WeightAPI.Entities;

namespace WeightAPI.Repositories
{
    public interface IExerciseRepository
    {
        Exercise GetExercise(int exerciseId);

        void AddExercise(Exercise exercise);

        bool Save();
    }
}
