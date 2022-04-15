using Microsoft.AspNetCore.Mvc;

namespace HorrorVillains.Web.Pages.Shared.Components.Demo;

public class DemoViewComponent : ViewComponent
{

	public IViewComponentResult Invoke()
	{
		return View();
	}
}
