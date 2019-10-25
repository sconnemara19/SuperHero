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

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            List<Superhero> superheroes = context.Superheroes.ToList();
           
            return View(superheroes);


        }
       

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            Superhero superhero = context.Superheroes.Where(s => s.SuperheroId == id).FirstOrDefault();
            return View(superhero);
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
                return RedirectToAction("List");
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
              Superhero dbsuperhero = context.Superheroes.Where(s => s.SuperheroId == id).FirstOrDefault();
               dbsuperhero.Superheroname = superhero.Superheroname;
               dbsuperhero.alterEgo = superhero.alterEgo;
               dbsuperhero.primaryAbility = superhero.primaryAbility;
               dbsuperhero.secondaryAbility = superhero.secondaryAbility;
               dbsuperhero.catchphrase = superhero.catchphrase;
                context.SaveChanges();
                return RedirectToAction("List");

            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int id)
        {
            Superhero superhero = context.Superheroes.Where(s => s.SuperheroId == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Superhero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                superhero = context.Superheroes.Where(s => s.SuperheroId == id).FirstOrDefault();
                context.Superheroes.Remove(superhero);
                context.SaveChanges();
                return RedirectToAction("List");

                
            }
            catch
            {
                return View();
            }
        }
    }
}
