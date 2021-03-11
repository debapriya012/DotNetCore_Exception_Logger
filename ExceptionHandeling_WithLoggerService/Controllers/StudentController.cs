using ExceptionHandeling_WithLoggerService.Models;
using LoggerService;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ExceptionHandeling_WithLoggerService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        private readonly ILoggerManager _logger;

        public StudentController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            ///Handeling exception Using Try Catch block---------------------------
            //try
            //{
            //    _logger.LogInfo("Fetching all the Students from the storage");

            //    var students = DataManager.GetAllStudents(); //simulation for the data base access

            //    throw new Exception("Exception while fetching all the students from the storage.");

            //    _logger.LogInfo($"Returning {students.Count} students.");

            //    return Ok(students);


            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError($"Something went wrong: {ex}");
            //    return StatusCode(500, "Internal server error");
            //}

            ///Handeling exception With the help of middleware
            _logger.LogInfo("Fetching all the Students from the storage");

            var students = DataManager.GetAllStudents(); //simulation for the data base access

            throw new Exception("Exception while fetching all the students from the storage.");

            _logger.LogInfo($"Returning {students.Count} students.");

            return Ok(students);

        }
    }
}
