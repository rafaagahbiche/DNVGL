namespace cubes.UI.Controllers
{
	using cubes.Data;
	using cubes.Services;
	using System.Web.Mvc;

	public class CubesController : Controller
    {
		private ICubesOperationsManager cubesManager;

		public CubesController(ICubesOperationsManager manager)
		{
			this.cubesManager = manager;
		}

		// GET: Cubes
		public ActionResult Index()
        {
			return View(cubesManager.Cubes);
        }

		[HttpPost]
		public PartialViewResult CalculateIntersection(CubesSpace myCubes)
		{
			cubesManager.Cubes = myCubes;
			var intersection = cubesManager.CalculateIntersection();
			return PartialView("CubeSpaceResult", $"The intersection is {intersection}");
		}

		[HttpGet]
		public PartialViewResult AddNewCube()
		{
			return PartialView("CubeEditor",
				new Cube()
				{
					Id = -1
				});
		}
	}
}