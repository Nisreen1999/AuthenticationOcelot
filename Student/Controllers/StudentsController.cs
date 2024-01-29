using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model = Student.Models;
namespace Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly Model.ContextClass _context;
        public StudentsController(Model.ContextClass context)
        {
            _context = context;
        }

        //GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Model.Student>>> Getstudent()
        {

            if (_context.student == null)
            {
                return NotFound();
            }
            var account = HttpContext.Request.Headers["Authorization"];
            return await _context.student.ToListAsync();
        }
    }
}
