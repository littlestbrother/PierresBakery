using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Bakery.Controllers {
  [Authorize]
  public class FlavorsController: Controller {
    private readonly BakeryContext _db;

    public FlavorsController(BakeryContext db) {
      _db = db;
    }

    [AllowAnonymous]
    public ActionResult Index() {
      List <Flavor> model = _db.Flavors.ToList();
      return View(model);
    }

    public ActionResult Create() {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor Flavor) {
      _db.Flavors.Add(Flavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [AllowAnonymous]
    public ActionResult Details(int id) {
      var thisFlavor = _db.Flavors
        .Include(Flavor => Flavor.JoinEntities)
        .ThenInclude(join => join.Treat)
        .FirstOrDefault(Flavor => Flavor.FlavorId == id);
      return View(thisFlavor);
    }
    public ActionResult Edit(int id) {
      var thisFlavor = _db.Flavors.FirstOrDefault(Flavor => Flavor.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult Edit(Flavor Flavor) {
      _db.Entry(Flavor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id) {
      var thisFlavor = _db.Flavors.FirstOrDefault(Flavor => Flavor.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id) {
      var thisFlavor = _db.Flavors.FirstOrDefault(Flavor => Flavor.FlavorId == id);
      _db.Flavors.Remove(thisFlavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}