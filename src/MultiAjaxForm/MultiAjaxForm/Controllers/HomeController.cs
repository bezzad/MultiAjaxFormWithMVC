using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using MultiAjaxForm.Models;

namespace MultiAjaxForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Employes = EmpModel.Employes;
            return View();
        }

        // GET: Home/EmployeeMaster
        [HttpGet]
        public ActionResult EmployeeMaster()
        {
            return View();
        }

        // POST: Home/EmployeeMaster Submit
        [HttpPost]
        public async Task<ActionResult> EmployeeMaster(EmpModel obj)
        {
            if (!ModelState.IsValid) return View();

            await Task.Delay(2000);

            EmpModel.Employes.Add(new EmpModel()
            {
                Name = obj.Name,
                Address = obj.Address,
                City = obj.City
            });

            ViewBag.Records = $"Successfully saved employee {obj.Name} from {obj.City}, {obj.Address}";
            return PartialView("EmployeeMaster", obj);
        }

        // POST: Home/SearchPeople Submit
        [HttpPost]
        public async Task<ActionResult> SearchPeople(string keyword)
        {
            await Task.Delay(2000);

            ViewBag.Employes = EmpModel.Employes.Where(f => f.Name.ToLower().Contains(keyword.ToLower())).ToList();

            return PartialView("SearchPeople");
        }
    }
}