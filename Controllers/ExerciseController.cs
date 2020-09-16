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
            try
            {
                if (!_exerciseRepository.ExerciseExists(id))
                    return NotFound();

                var exercise = _mapper.Map<ExerciseDto>(_exerciseRepository.GetExercise(id));
                return Ok(exercise);
            }
            catch (Exception e)
            {
                return StatusCode(500, "A error occurred while handling your request");
            }
        }

        [HttpPost]
        public IActionResult CreateExercise(ExerciseDto exercise)
        {
            _exerciseRepository.AddExercise(_mapper.Map<Exercise>(exercise));
            _exerciseRepository.Save();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteExercise(int exerciseId)
        {
            if (!_exerciseRepository.ExerciseExists(exerciseId))
                return NotFound();
            try
            {
                var exercise = _exerciseRepository.GetExercise(exerciseId);
                _exerciseRepository.DeleteExercise(exercise);
                _exerciseRepository.Save();
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, "There was an error while trying to delete the specified exercise");
            }
        }
    }
}
