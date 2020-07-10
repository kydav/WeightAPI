using System;
using System.Collections.Generic;
using WeightAPI.Entities;

namespace WeightAPI.Repositories
{
    public interface IExerciseRepository
    {
        Exercise GetExercise(int exerciseId);

        List<Exercise> GetExercises();

        void AddExercise(Exercise exercise);

        void DeleteExercise(Exercise exercise);

        bool ExerciseExists(int exerciseId);

        bool Save();
    }
}
