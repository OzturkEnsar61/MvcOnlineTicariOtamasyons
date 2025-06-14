﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 
using System.Web.Mvc;
using MvcOnlineTicariOtamasyons.Models.Sınıflar;


namespace MvcOnlineTicariOtamasyons.Controllers
{
    public class DepartmanController : Controller
    {
        // GET: Departman
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Departmans.Where(x => x.Durum == true).ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult DepartmanEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DepartmanEkle(Departman d)
        {
            d.Durum = true;
            c.Departmans.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepartmanSil(int id)
        {
            var dep = c.Departmans.Find(id);
            dep.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepartmanGetir(int id)
        {
            var dpt = c.Departmans.Find(id);
            return View("DepartmanGetir", dpt);
        }

        public ActionResult DepartmanGuncelle(Departman p)
        {
            var dept = c.Departmans.Find(p.DeparmanID);
            dept.DeparmanAd = p.DeparmanAd;
            //dept.Durum = true;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DepartmanDetay(int id)
        {
            var degerler = c.Personels.Where(x => x.Departmanid == id).ToList();
            var dpt=c.Departmans.Where(x => x.DeparmanID == id).Select(y => y.DeparmanAd).FirstOrDefault();
            ViewBag.d = dpt;
            return View(degerler);


        }
    }
}