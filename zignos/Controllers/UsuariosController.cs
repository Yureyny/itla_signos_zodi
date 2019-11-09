using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using zignos.Models;

namespace zignos.Controllers
{
    public class UsuariosController : Controller
    {
        private zignosContext db = new zignosContext();

        // GET: Usuarios
        public ActionResult Index()
        {
            return View(db.Usuario.ToList());
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(string id)
        {
           
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            DateTime fecha= usuario.Fecha_Nacimiento;
            int mes = fecha.Month;
            int dia = fecha.Day;
            string zigno = "";
            string url = "#";
            switch (mes)
            {
                case 1:
                    if (dia >= 1 && dia <= 20) {
                        zigno = "Capricornio";
                        url = "/Content/img/capricorn.png";

                    }
                    else if(dia >= 01 && dia <= 20){
                        zigno = "Acuario";
                        url = "/Content/img/aquarius.png";
                    }
                 break;
                case 2:
                    if (dia >= 1 && dia <= 19)
                    {
                        zigno = "Acuario";
                        url = "/Content/img/aquarius.png";

                    }
                    else if (dia >= 20 && dia <= 29)
                    {
                        zigno = "Piscis";
                        url = "/Content/img/pisces.png";
                        
                    }
                    break;
                case 3:
                    if (dia >= 1 && dia <= 20)
                    {
                        zigno = "Piscis";
                        url = "/Content/img/pisces.png";

                    }
                    else if (dia >= 21 && dia <= 31)
                    {
                        zigno = "Aries";
                        url = "/Content/img/aries.png";
                    }
                    break;
                case 4:
                    if (dia >= 1 && dia <= 20)
                    {
                        zigno = "Aries";
                        url = "/Content/img/aries.png";

                    }
                    else if (dia >= 21 && dia <= 30)
                    {
                        zigno = "Tauro";
                        url = "/Content/img/taurus.png";
                    }
                    break;
                case 5:
                    if (dia >= 1 && dia <= 21)
                    {
                        zigno = "Tauro";
                        url = "/Content/img/taurus.png";

                    }
                    else if (dia >= 22 && dia <= 31)
                    {
                        zigno = "Geminis";
                        url = "/Content/img/gemini.png";
                    }
                    break;
                case 6:
                    if (dia >= 1 && dia <= 21)
                    {
                        zigno = "Geminis";
                        url = "/Content/img/gemini.png";

                    }
                    else if (dia >= 22 && dia <= 30)
                    {
                        zigno = "Cancer";
                        url = "/Content/img/cancer.png";
                    }
                    break;
                case 7:
                    if (dia >= 1 && dia <= 22)
                    {
                        zigno = "Cancer";
                        url = "/Content/img/cancer.png";

                    }
                    else if (dia >= 23 && dia <= 31)
                    {
                        zigno = "Leo";
                        url = "/Content/img/leo.png";
                    }
                    break;
                case 8:
                    if (dia >= 1 && dia <= 22)
                    {
                        zigno = "Leo";
                        url = "/Content/img/leo.png";

                    }
                    else if (dia >= 23 && dia <= 31)
                    {
                        zigno = "Virgo";
                        url = "/Content/img/virgo.png";
                    }
                    break;
                case 9:
                    if (dia >= 1 && dia <= 22)
                    {
                        zigno = "Virgo";
                        url = "/Content/img/virgo.png";

                    }
                    else if (dia >= 23 && dia <= 30)
                    {
                        zigno = "Libra";
                        url = "/Content/img/libra.png";
                    }
                    break;
                case 10:
                    if (dia >= 1 && dia <= 22)
                    {
                        zigno = "Libra";
                        url = "/Content/img/libra.png";

                    }
                    else if (dia >= 23 && dia <= 31)
                    {
                        zigno = "Escorpion";
                        url = "/Content/img/scorpio.png";
                    }
                    break;
                case 11:
                    if (dia >= 1 && dia <= 22)
                    {
                        zigno = "Escorpion";
                        url = "/Content/img/scorpio.png";

                    }
                    else if (dia >= 23 && dia <= 30)
                    {
                        zigno = "Sagitario";
                        url = "/Content/img/sagittarius.png";
                    }
                    break;
                case 12:
                    if (dia >= 1 && dia <= 22)
                    {
                        zigno = "Sagitario";
                        url = "/Content/img/sagittarius.png";

                    }
                    else if (dia >= 23 && dia <= 31)
                    {
                        zigno = "Capricornio";
                        url = "/Content/img/capricorn.png";
                    }
                    break;

            }

            ViewBag.zigno = zigno;
            ViewBag.url = url;
            return View(usuario);
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsuarioID,Nombre,Apellido,Cedula,Fecha_Nacimiento")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Usuario.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsuarioID,Nombre,Apellido,Cedula,Fecha_Nacimiento")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Usuario usuario = db.Usuario.Find(id);
            db.Usuario.Remove(usuario);
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
