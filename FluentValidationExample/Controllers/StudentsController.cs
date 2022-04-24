using FluentValidationExample.Data;
using FluentValidationExample.Entities;
using FluentValidationExample.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IRepository<Student> repository;
        public StudentsController(IRepository<Student> _repository)
        {
            repository = _repository;
        }
        [HttpPost]
        public ActionResult Add([FromBody] Student student)
        {
            var validator = new StudentValidator();
            var result = validator.Validate(student);
            if (result.IsValid)
            {
                repository.Add(student);
                repository.SaveAll(); 
                return Ok(student);
            }
            else
                return BadRequest(result.Errors);
        }
    }
}
