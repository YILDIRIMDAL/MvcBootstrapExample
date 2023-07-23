using MvcyeBootstrap314EklemeDenemesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcyeBootstrap314EklemeDenemesi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Haber haber1 = new Haber();

            haber1.Id= 1;
            haber1.Baslik = "JUMANJI";
            haber1.İcerik = "Jumanji is here, coming soon";
            haber1.OlusturulmaTarihi = DateTime.Now;
            haber1.FotoUrl = "https://dlby.tmsimg.com/assets/p13499680_p_v7_bb.jpg";
            haber1.FotoUrl2 = "https://m.media-amazon.com/images/M/MV5BMjM0NTQ5NjI0N15BMl5BanBnXkFtZTgwNDI4NTY3MjI@._V1_.jpg";
            haber1.FotoUrl3 = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6169/6169135_so.jpg";
            haber1.FotoUrl4 = "https://lonepeakcinema.com/wp-content/uploads/2017/12/Jumanji-Welcome-To-The-Jungle-Movie-Trailer-2017.jpg";
            haber1.FotoUrl5 = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6169/6169135_so.jpg";


            return View(haber1);
        }
    }
}