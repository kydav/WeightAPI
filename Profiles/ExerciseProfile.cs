using System;
using AutoMapper;

namespace WeightAPI.Profiles
{
    public class ExerciseProfile : Profile
    {
        public ExerciseProfile()
        {
            CreateMap<Entities.Exercise, Models.ExerciseDto>();
            CreateMap<Entities.ExerciseStep, Models.ExerciseStepDto>();
        }
    }
}
