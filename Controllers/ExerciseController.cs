using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WeightAPI.Entities;
using WeightAPI.Models;
using WeightAPI.Repositories;

namespace WeightAPI.Controllers
{
    [ApiController]
    [Route("api/exercise")]
    public class ExerciseController : ControllerBase
    {
        private IExerciseRepository _exerciseRepository;
        private readonly IMapper _mapper;

        public ExerciseController(IExerciseRepository exerciseRepository, IMapper mapper)
        {
            _exerciseRepository = exerciseRepository ?? throw new ArgumentNullException(nameof(exerciseRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{id}", Name = "GetExerciseById")]
        public IActionResult GetExercise(int id)
        {
            
            return Ok(_exerciseRepository.GetExercise(id));
        }

        [HttpPost]
        public IActionResult CreateExercise(ExerciseDto exercise)
        {
            _exerciseRepository.AddExercise(_mapper.Map<Exercise>(exercise));
            return Ok();

        }
    }
}
