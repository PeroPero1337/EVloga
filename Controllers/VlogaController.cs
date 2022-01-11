using EVloga.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EVloga.Controllers
{
    public class VlogaController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(OsebniPodatki osebni)
        {
            using (var db = new EvlogaContext())
            {
                if (ModelState.IsValid)
                {
                    osebni.Vlagatelj = User.Identity.Name;
                    osebni.DatumOddaje = DateTime.Now;
                    osebni.Status = "V obdelavi";
                    db.podatki.Add(osebni);
                    db.SaveChanges();
                    return RedirectToAction("File1", "Vloga");
                }
            }
            
            return View(osebni);
        }

        public IActionResult File1()
        {
            return View();
        }

        public void UploadDocs(IFormFile files, EvlogaContext db)
        {
            if (files != null)
            {
                if (files.Length > 0)
                {
                    var fileName = Path.GetFileName(files.FileName);
                    var fileExtension = Path.GetExtension(fileName);
                    var newFileName = String.Concat(fileName, fileExtension);
                    var objFiles = new Dokument()
                    {
                        Id = 0,
                        DocName = newFileName,
                        FileType = fileExtension,
                        CreatedOn = DateTime.Now,
                        Oseba = User.Identity.Name
                    };
                    using (var target = new MemoryStream())
                    {
                        files.CopyTo(target);
                        objFiles.File = target.ToArray();
                    }
                    db.dokumenti.Add(objFiles);
                    db.SaveChanges();
                }
            }
        }

        [HttpPost]
        public IActionResult File1(IFormFile files)
        {
            using(var db = new EvlogaContext())
            {
                UploadDocs(files,db);

                return RedirectToAction("File2","Vloga");
            }
        }

        public IActionResult File2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult File2(IFormFile files)
        {
            using (var db = new EvlogaContext())
            {
                UploadDocs(files, db);

                return RedirectToAction("File3", "Vloga");
            }
        }

        public IActionResult File3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult File3(IFormFile files)
        {
            using (var db = new EvlogaContext())
            {
                UploadDocs(files, db);

                return RedirectToAction("File4", "Vloga");
            }
        }

        public IActionResult File4()
        {
            return View();
        }

        [HttpPost]
        public IActionResult File4(IFormFile files)
        {
            using (var db = new EvlogaContext())
            {
                UploadDocs(files, db);

                return RedirectToAction("Finish", "Vloga");
            }
        }

        public IActionResult Finish()
        {
            return View();
        }
    }
}
