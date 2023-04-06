using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Controllers
{
    public class SanphamController : Controller
    {
        Qlbanhang db = new Qlbanhang();
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> develop
        public ActionResult Index(string searchString)
        {
            var links = from l in db.Sanphams
                        select l;

            if (!String.IsNullOrEmpty(searchString))
            {
                links = links.Where(s => s.Tensp.Contains(searchString));
            }

            return PartialView(links);
        }
<<<<<<< HEAD

        // GET: Sanpham
        public ActionResult womenday()
=======

        // GET: Sanpham
        public ActionResult dtiphonepartial()
>>>>>>> 2a759a8020b02aeac8fb7e8a0e59c59926521ecd
=======

        // GET: Sanpham
        public ActionResult womenday()
>>>>>>> develop
        {
            var ip = db.Sanphams.Where(n=>n.Mahang==2).Take(4).ToList();
           return PartialView(ip);
        }
<<<<<<< HEAD
<<<<<<< HEAD
        public ActionResult motherday()
=======
        public ActionResult dtsamsungpartial()
>>>>>>> 2a759a8020b02aeac8fb7e8a0e59c59926521ecd
=======
        public ActionResult motherday()
>>>>>>> develop
        {
            var ss = db.Sanphams.Where(n => n.Mahang == 1).Take(4).ToList();
            return PartialView(ss);
        }
<<<<<<< HEAD
<<<<<<< HEAD
        public ActionResult valentine()
=======
        public ActionResult dtxiaomipartial()
>>>>>>> 2a759a8020b02aeac8fb7e8a0e59c59926521ecd
=======
        public ActionResult valentine()
>>>>>>> develop
        {
            var mi = db.Sanphams.Where(n => n.Mahang == 3).Take(4).ToList();
            return PartialView(mi);
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> develop

        public ActionResult listproducts()
        {
            var list = db.Sanphams.ToList();
                
            return PartialView(list);
        }
   

<<<<<<< HEAD
=======
>>>>>>> 2a759a8020b02aeac8fb7e8a0e59c59926521ecd
=======
>>>>>>> develop
        //public ActionResult dttheohang()
        //{
        //    var mi = db.Sanphams.Where(n => n.Mahang == 5).Take(4).ToList();
        //    return PartialView(mi);
        //}
        public ActionResult xemchitiet(int Masp=0)
        {
            var chitiet = db.Sanphams.SingleOrDefault(n=>n.Masp==Masp);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }

    }

}