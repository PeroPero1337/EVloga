using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using EVloga.Models;
using System.Threading.Tasks;
using System.IO;

namespace EVloga.Controllers
{
    public class OddanoController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new EvlogaContext())
            {
                var returnedList = new List<OsebniPodatki>();
                var temp = db.podatki.ToList();
                foreach (var item in temp)
                {
                    if (item.Status.ToUpper() == "V OBDELAVI")
                        returnedList.Add(item);
                }
                return View(returnedList);
            }
            
        }

        public IActionResult Details(OsebniPodatki item)
        {
            using(var db = new EvlogaContext())
            {
                var person = db.podatki.Find(item.OsebniId); 
                return View(person);

            }
        }

        public IActionResult GetFiles(OsebniPodatki user) //TODO: Fix ker crasha celo povezavo
        {
            using(var db = new EvlogaContext())
            {
                var files = db.dokumenti.Where(x => x.Oseba == user.Vlagatelj);
                return View(files.ToList());
            }
        }

        public IActionResult Download(Dokument doc)
        {
            using (var db = new EvlogaContext())
            {
                var file = db.dokumenti.Find(doc.Id);
                var fileBytes = file.File;
                var fileName = file.DocName;

                using (Stream s = System.IO.File.OpenWrite(@"E:\School\FERI 3.letnik\UIKT\DOCS" + fileName))
                {
                    s.Write(fileBytes, 0, fileBytes.Length);
                }

                return View();
            }
        }

        public OsebniPodatki DenyApprove(OsebniPodatki user, string status)
        {
            var updated = new OsebniPodatki()
            {
                OsebniId = user.OsebniId,
                Ime = user.Ime,
                RojDan = user.RojDan,
                KrajRojstva = user.KrajRojstva,
                EMSO = user.EMSO,
                Davcna = user.Davcna,
                Vlagatelj = user.Vlagatelj,
                DatumOddaje = user.DatumOddaje,
                Status = status
            };

            return updated;
        }

        public IActionResult Approved(OsebniPodatki user)
        {
            using(var db = new EvlogaContext())
            {

                var updated = DenyApprove(user, "Odobreno");
                db.podatki.Attach(updated);
                db.Entry(updated).Property(x => x.Status).IsModified = true;
                db.SaveChanges();
                return View();
            }
            
        }

        public IActionResult Denied(OsebniPodatki user)
        {
            using (var db = new EvlogaContext())
            {
                var updated = DenyApprove(user, "Zavrnjeno");
                db.podatki.Attach(updated);
                db.Entry(updated).Property(x => x.Status).IsModified = true;
                db.SaveChanges();
                return View();
            }
        }
    }
}
