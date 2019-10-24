using SuperHero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHero.Controllers
{
    public class SuperheroController : Controller
    {
        ApplicationDbContext context;
        public SuperheroController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Superhero
        public ActionResult Index()
        {

            var superheroList = new List<Superhero>
            {
                new Superhero() {SuperheroId = 1, Superheroname = "IronMan", alterEgo = "Tony Stark", primaryAbility= "Being Smart", secondaryAbility ="Being Rich", catchphrase ="I am IronMan" },
                new Superhero() {SuperheroId = 2, Superheroname = "Star-Lord", alterEgo = "Peter Quill", primaryAbility= "Stealing", secondaryAbility= "Super Human Strength", catchphrase="Keep Karate In Your Heart"},
                new Superhero() {SuperheroId = 3, Superheroname = " AntMan", alterEgo = "Scott Lang", primaryAbility= "turning small", secondaryAbility = "stealing", catchphrase="Hello. I'm Ant-Man"},
                new Superhero() {SuperheroId = 4, Superheroname = "Venom",alterEgo = "Eddie Brock", primaryAbility= "Super strength",secondaryAbility="Shape shifting",catchphrase="We are Venom"}
            };

            
            return View(superheroList);
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superhero/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Superheroes.Add(superhero);
                context.SaveChanges(); 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Edit/5
        public ActionResult Edit(int id)
        {
            Superhero superhero = context.Superheroes.Where(s => s.SuperheroId == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Superhero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
