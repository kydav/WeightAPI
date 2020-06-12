using System;
using Microsoft.AspNetCore.Mvc;

namespace WeightAPI.Controllers
{
    [ApiController]
    [Route("api/exercise")]
    public class ExerciseController
    {
        public ExerciseController()
        {

        }

        [HttpGet("{id}")]
        public IActionResult GetExercise(int id)
        {
            return NotImplementedException();
        }
    }
}
