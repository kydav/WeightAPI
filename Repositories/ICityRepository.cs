using System;
using WeightAPI.Entities;

namespace WeightAPI.Repositories
{
    public interface ICityRepository
    {
        Exercise GetExercise(int exerciseId);

        void AddExercise(Exercise exercise);

        bool Save();
    }
}
