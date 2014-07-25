using System.Web.Mvc;

namespace MediaManager.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var m = new CombinedModel();
            m.Person = new MyModel();
            m.Person.FirstName = "Mike";
            m.Person.LastName = "Eaton";

            m.Random = new AnotherModel();
            m.Random.SomePieceOfData = "This is a random string";

            ViewBag.Message = "Your application description page.";
            ViewBag.SubTitle = "This is the title";

            return View(m);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class MyModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class AnotherModel
    {
        public string SomePieceOfData { get; set; }
    }

    public class CombinedModel
    {
        public MyModel Person { get; set; }
        public AnotherModel Random { get; set; }
    }
}