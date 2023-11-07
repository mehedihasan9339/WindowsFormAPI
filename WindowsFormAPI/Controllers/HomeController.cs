using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WindowsFormAPI.Context;

namespace WindowsFormAPI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly databaseContext _context;

        public HomeController(databaseContext context)
        {
            _context = context;
        }


        [HttpGet("employeeList")]
        public async Task<ActionResult> EmployeeList()
        {
            var model = await _context.EmployeeInfo.AsNoTracking().ToListAsync();
            
            return Ok(model);
        }

    }
}
