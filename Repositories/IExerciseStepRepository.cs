using System;
using System.Collections.Generic;
using WeightAPI.Entities;

namespace WeightAPI.Repositories
{
    public interface IExerciseStepRepository
    {
        ExerciseStep GetExerciseStep(int exerciseStepId);

        List<ExerciseStep> GetExerciseSteps(int exerciseId);

        void AddExerciseStep(ExerciseStep exerciseStep);

        void AddExerciseSteps(List<ExerciseStep> exerciseSteps);

        bool Save();
    }
}
