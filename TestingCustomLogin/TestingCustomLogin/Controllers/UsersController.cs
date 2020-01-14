using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingCustomLogin.CustomAuthentication;

namespace TestingCustomLogin.Controllers
{
	public class UsersController : Controller
	{
		[CustomAuthorize(Roles = "User")]
		// GET: Users  
		public ActionResult Index()
		{
			return View();
		}

	}
}