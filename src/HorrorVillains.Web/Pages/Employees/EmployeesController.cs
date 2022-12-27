using Microsoft.AspNetCore.Mvc;

namespace HorrorVillains.Web.Pages.Employees;

[Route("employees")]
public class EmployeesController : Controller
{
	// GET
	[HttpGet("test")]
	public IActionResult Test()
	{
		return Ok("From Controller");
	}
}
