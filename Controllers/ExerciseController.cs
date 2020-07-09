using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        private IExerciseStepRepository _exerciseStepRepository;
        private readonly IMapper _mapper;

        public ExerciseController(IExerciseRepository exerciseRepository, IExerciseStepRepository exerciseStepRepository, IMapper mapper)
        {
            _exerciseRepository = exerciseRepository ?? throw new ArgumentNullException(nameof(exerciseRepository));
            _exerciseStepRepository = exerciseStepRepository ?? throw new ArgumentNullException(nameof(exerciseStepRepository));
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
            _exerciseRepository.Save();
            //if(exercise.Steps.Count > 0)
            //{
            //    var steps = exercise.Steps.ToList();
            //    foreach (var step in steps)
            //        //TODO: Need to find a way to add the exercise to the step before it saves otherwise the foreign
            //        //key doesn't exist and it can't save the steps.  
            //        _exerciseStepRepository.AddExerciseStep(_mapper.Map<ExerciseStep>(step));
            //    _exerciseStepRepository.Save();
            //}
            return Ok();

        }
    }
}
