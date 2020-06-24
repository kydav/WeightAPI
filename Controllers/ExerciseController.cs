using System;
using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Http;
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Exercise>))]
        public IActionResult GetExercises()
        {
            return Ok(_exerciseRepository.GetExercises());
        }
        [HttpGet("{id}")]//, Name = "GetExerciseById")]
        public IActionResult GetExercise(int id)
        {
            var exercise = _exerciseRepository.GetExercise(id);
            return Ok(exercise);
        }

        [HttpPost]
        public IActionResult CreateExercise(ExerciseDto exercise)
        {
            _exerciseRepository.AddExercise(_mapper.Map<Exercise>(exercise));
            return Ok();

        }
    }
}
