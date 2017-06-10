using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2015104916.Entities.Entities;
using _2015104916.Persistence;

namespace _2015104916.MVC.Controllers
{
    public class AutomovilesController : Controller
    {
        private _2015104916DbContext db = new _2015104916DbContext();
        public ActionResult Index()
        {
            var automoviles = db.Automoviles.Include(c => c.Ensambladora).Include(c => c.Parabrisas).Include(c => c.Propietario).Include(c => c.Volante);
            return View(automoviles.ToList());
        }

        // GET: Carros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automovil automoviles = db.Automoviles.Find(id);
            if (automoviles == null)
            {
                return HttpNotFound();
            }
            return View(automoviles);
        }

        // GET: Carros/Create
        public ActionResult Create()
        {
            ViewBag.EnsambladoraId = new SelectList(db.Ensambladoras, "EnsambladoraId", "Nombre");
            ViewBag.CarroId = new SelectList(db.Parabrisas, "ParabrisasId", "NumSerie");
            ViewBag.CarroId = new SelectList(db.Propietarios, "PropietarioId", "Dni");
            ViewBag.CarroId = new SelectList(db.Volantes, "VolanteId", "NumSerie");
            return View();
        }

        // POST: Carros/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CarroId,Placa,NumSerieMotor,NumSerieChasis,EnsambladoraId,TipoCarro,TipoAuto")] Automovil automovil)
        {
            if (ModelState.IsValid)
            {
                db.Automoviles.Add(automovil);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EnsambladoraId = new SelectList(db.Ensambladoras, "EnsambladoraId", "Nombre", automovil.EnsambladoraId);
            ViewBag.CarroId = new SelectList(db.Parabrisas, "ParabrisasId", "NumSerie", automovil.CarroId);
            ViewBag.CarroId = new SelectList(db.Propietarios, "PropietarioId", "Dni", automovil.CarroId);
            ViewBag.CarroId = new SelectList(db.Volantes, "VolanteId", "NumSerie", automovil.CarroId);
            return View(automovil);
        }

        // GET: Carros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automovil automovil = db.Automoviles.Find(id);
            if (automovil == null)
            {
                return HttpNotFound();
            }
            ViewBag.EnsambladoraId = new SelectList(db.Ensambladoras, "EnsambladoraId", "Nombre", automovil.EnsambladoraId);
            ViewBag.CarroId = new SelectList(db.Parabrisas, "ParabrisasId", "NumSerie", automovil.CarroId);
            ViewBag.CarroId = new SelectList(db.Propietarios, "PropietarioId", "Dni", automovil.CarroId);
            ViewBag.CarroId = new SelectList(db.Volantes, "VolanteId", "NumSerie", automovil.CarroId);
            return View(automovil);
        }

        // POST: Carros/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CarroId,Placa,NumSerieMotor,NumSerieChasis,EnsambladoraId,TipoCarro,TipoAuto")] Automovil automovil)
        {
            if (ModelState.IsValid)
            {
                db.Entry(automovil).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EnsambladoraId = new SelectList(db.Ensambladoras, "EnsambladoraId", "Nombre", automovil.EnsambladoraId);
            ViewBag.CarroId = new SelectList(db.Parabrisas, "ParabrisasId", "NumSerie", automovil.CarroId);
            ViewBag.CarroId = new SelectList(db.Propietarios, "PropietarioId", "Dni", automovil.CarroId);
            ViewBag.CarroId = new SelectList(db.Volantes, "VolanteId", "NumSerie", automovil.CarroId);
            return View(automovil);
        }

        // GET: Carros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automovil automovil = db.Automoviles.Find(id);
            if (automovil == null)
            {
                return HttpNotFound();
            }
            return View(automovil);
        }

        // POST: Carros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Automovil bus = db.Automoviles.Find(id);
            db.Carros.Remove(bus);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
