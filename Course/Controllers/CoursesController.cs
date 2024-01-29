using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Model = Course.Models;

namespace Course.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CoursesController : ControllerBase
    {
        private readonly Model.ContextClass _context;

        public CoursesController(Model.ContextClass context)
        {
            _context = context;
        }

        // GET: api/Courses
        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<Model.Course>>> GetCourses()
        {
            if (_context.course == null)
            {
                return NotFound();
            }
            return await _context.course.ToListAsync();
        }
    }
}
