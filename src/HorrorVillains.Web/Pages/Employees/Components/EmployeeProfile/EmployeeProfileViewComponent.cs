using Microsoft.AspNetCore.Mvc;

namespace HorrorVillains.Web.Pages.Employees.Components.EmployeeProfile;

public class EmployeeProfileViewComponent : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
