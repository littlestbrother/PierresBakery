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
  public class TreatsController: Controller {
    private readonly BakeryContext _db;
    private readonly UserManager <ApplicationUser> _userManager;

    public TreatsController(UserManager <ApplicationUser> userManager, BakeryContext db) {
      _userManager = userManager;
      _db = db;
    }

    [AllowAnonymous]
    public ActionResult Index() {
      // var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      // var currentUser = await _userManager.FindByIdAsync(userId);
      // var userTreats = _db.Treats.Where(entry => entry.User.Id == currentUser.Id).ToList();
      // return View(userTreats);
      return View(_db.Treats.ToList());
    }

    public ActionResult Create() {
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View();
    }

    [HttpPost]
    public async Task <ActionResult> Create(Treat Treat, int FlavorId) {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      Treat.User = currentUser;
      _db.Treats.Add(Treat);
      _db.SaveChanges();
      if (FlavorId != 0) {
        _db.FlavorTreat.Add(new FlavorTreat() {
          FlavorId = FlavorId, TreatId = Treat.TreatId
        });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [AllowAnonymous]
    public ActionResult Details(int id) {
      var thisTreat = _db.Treats
        .Include(Treat => Treat.JoinEntities)
        .ThenInclude(join => join.Flavor)
        .FirstOrDefault(Treat => Treat.TreatId == id);
      return View(thisTreat);
    }

    public ActionResult Edit(int id) {
      var thisTreat = _db.Treats.FirstOrDefault(Treat => Treat.TreatId == id);
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult Edit(Treat Treat, int FlavorId) {
      if (FlavorId != 0) {
        _db.FlavorTreat.Add(new FlavorTreat() {
          FlavorId = FlavorId, TreatId = Treat.TreatId
        });
      }
      _db.Entry(Treat).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddFlavor(int id) {
      var thisTreat = _db.Treats.FirstOrDefault(Treat => Treat.TreatId == id);
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult AddFlavor(Treat Treat, int FlavorId) {
      if (FlavorId != 0) {
        _db.FlavorTreat.Add(new FlavorTreat() {
          FlavorId = FlavorId, TreatId = Treat.TreatId
        });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id) {
      var thisTreat = _db.Treats.FirstOrDefault(Treat => Treat.TreatId == id);
      return View(thisTreat);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id) {
      var thisTreat = _db.Treats.FirstOrDefault(Treat => Treat.TreatId == id);
      _db.Treats.Remove(thisTreat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteFlavor(int joinId) {
      var joinEntry = _db.FlavorTreat.FirstOrDefault(entry => entry.FlavorTreatId == joinId);
      _db.FlavorTreat.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}