using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HomeWork_LinoyDangur.Shared.Models.Courses;
using HomeWork_LinoyDangur.Server.Pages.HomeWork_LinoyDangur.Shared.Models.Courses;

namespace HomeWork_LinoyDangur.Server.Controllers
{
    [Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{
    [HttpGet("{str}")]
    public async Task<IActionResult> Check(string str)
    {
        int space = str.IndexOf(" ");
        // if space was not found
        if (space == -1)
        {
            return BadRequest(str);
        }
        else
        {
            return Ok(str.Substring(0, space));
        }
    }

    [HttpPost]
    public async Task<IActionResult> CheckCourse(Course course)
    {
        if (course != null)
        {
            if (course.Teacher.IndexOf(" ") == -1)
            {
                course.Teacher += "no";
                return Ok();
            }
            else
            {
                return Ok(course);
            }
        }
        else
        {
            return BadRequest();
        }
    }
}
}
