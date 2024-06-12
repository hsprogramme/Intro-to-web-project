using Web.Models;
using Microsoft.AspNetCore.Mvc;


namespace Web.Controllers
{
    public class FirstController : Controller
    {
        private readonly WebDbContext _Db;
        public FirstController(WebDbContext db)
        {
            _Db = db;
        }
        public IActionResult Index()
        {
            var datalist = _Db.DataModels.ToList();
            return View(datalist);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DataModel model)
        {
            _Db.DataModels.Add(model);
            _Db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _Db.DataModels.Where(x => x.Id == id).FirstOrDefault();
            return View(data);

        }
        [HttpPost]
        public ActionResult Edit(DataModel model)
        {
            var data = _Db.DataModels.Where(x => x.Id == model.Id).FirstOrDefault();
            if (data != null)
            {
                data.Name = model.Name;
                data.Email = model.Email;
                data.Address = model.Address;
                data.DOB = model.DOB;
                _Db.SaveChanges();
            }
            return View();
        }
        public ActionResult Details(int id)
        {
            var data = _Db.DataModels.Where(x => x.Id == id).FirstOrDefault();
            return View(data);

        }
        public ActionResult Delete(int id)
        {
            var ddata = _Db.DataModels.Where(x => x.Id == id).FirstOrDefault();
            _Db.DataModels.Remove(ddata);
            _Db.SaveChanges();
            return RedirectToAction("Index");

        }
    }

}
