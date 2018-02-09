using Games.Models;
using Games.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Games.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult NumberGame()
        {
            GameDb context = new GameDb();
            ViewBag.scores = context.Number.OrderBy(c => c.HighScore).ToList();
            return View(new NumberGameViewModel());
        }
        public ActionResult NumberGameBS(NumberGameViewModel score)
        {
            GameDb context = new GameDb();
            NumberGameEntity num = new NumberGameEntity();
            num.HighScore = score.HighScore;
            context.Number.Add(num);
            context.SaveChanges();
            var worstScore =context.Number.OrderByDescending(c => c.HighScore).First();
            context.Number.Remove(worstScore);
            context.SaveChanges();
            return RedirectToAction("NumberGame");
        }
        public ActionResult SpaceshipGame()
        {
            GameDb context = new GameDb();
            ViewBag.scores = context.Spaceship.OrderByDescending(c => c.HighScore).ToList();
            return View(new SpaceshipGameViewModel());
        }
        public ActionResult SpaceshipGameBS(SpaceshipGameViewModel score)
        {
            GameDb context = new GameDb();
            SpaceshipGameEntity num = new SpaceshipGameEntity();
            num.HighScore = score.HighScore;
            context.Spaceship.Add(num);
            context.SaveChanges();
            var worstScore = context.Spaceship.OrderBy(c => c.HighScore).First();
            context.Spaceship.Remove(worstScore);
            context.SaveChanges();
            return RedirectToAction("SpaceshipGame");
        }
    }
}