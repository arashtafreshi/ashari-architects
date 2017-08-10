using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ashari_architects.com.Models;
using Microsoft.AspNetCore.Mvc;

namespace ashari_architects.com.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Proj()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Cards(string id)
        {
            List<string> images = new List<string>();
            switch (id)
            {
                case "maternal_house":
                    ViewData["Message"] = "MATERNAL HOUSE";
                    images.Add("/images/Maternal - House ( خانه مادری )/Main elevation/008.jpg");
                    images.Add("/images/Maternal - House ( خانه مادری )/Main elevation/1.jpg");
                    images.Add("/images/Maternal - House ( خانه مادری )/Main elevation/2.jpg");
                    images.Add("/images/Maternal - House ( خانه مادری )/Main elevation/IMG_7908.JPG");
                    images.Add("/images/Maternal - House ( خانه مادری )/Main elevation/Untitled-1.jpg");
                    break;
                case "conex_cafe":
                    ViewData["Message"] = "CONEX CAFE";
                    images.Add("/images/conex cafe/conex cafe   (12).jpg");
                    images.Add("/images/conex cafe/conex cafe   (3).jpg");
                    images.Add("/images/conex cafe/conex cafe   (14).JPG");
                    images.Add("/images/conex cafe/conex cafe   (6).jpg");
                    images.Add("/images/conex cafe/conex cafe   (9).jpg");
                    break;
                case "nori_house":
                    ViewData["Message"] = "NORI HOUSE";
                    images.Add("/images/Nouri House/NORI HOUSE   (16).JPG");
                    images.Add("/images/Nouri House/NORI HOUSE   (18).JPG");
                    images.Add("/images/Nouri House/NORI HOUSE   (7).JPG");
                    images.Add("/images/Nouri House/NORI HOUSE   (9).JPG");
                    images.Add("/images/Nouri House/NORI HOUSE   (3).JPG");
                    break;
                case "cafe_mosalas":
                    ViewData["Message"] = "CAFE MOSALAS";
                    images.Add("/images/Cafe Mosalas/Cafe Mosalas (4).JPG");
                    images.Add("/images/Cafe Mosalas/Cafe Mosalas (2).JPG");
                    images.Add("/images/Cafe Mosalas/Cafe Mosalas (14).jpg");
                    images.Add("/images/Cafe Mosalas/Cafe Mosalas (12).jpg");
                    images.Add("/images/Cafe Mosalas/Cafe Mosalas (10).jpg");
                    break;
                case "falah_house":
                    ViewData["Message"] = "FALAH HOUSE";
                    images.Add("/images/Falah House/Falah House (1).jpg");
                    images.Add("/images/Falah House/Falah House (4).jpg");
                    images.Add("/images/Falah House/Falah House (8).jpg");
                    images.Add("/images/Falah House/Falah House (10).jpg");
                    images.Add("/images/Falah House/Falah House (12).jpg");
                    break;
                case "hafezieh_prayer_room":
                    ViewData["Message"] = "HAFEZIEH PRAYER ROOM";
                    images.Add("/images/Hafezieh Prayer Room/render/hafezieh prayer room   (2).jpg");
                    images.Add("/images/Hafezieh Prayer Room/render/hafezieh prayer room   (3).jpg");
                    images.Add("/images/Hafezieh Prayer Room/render/hafezieh prayer room   (4).jpg");
                    images.Add("/images/Hafezieh Prayer Room/render/hafezieh prayer room   (6).jpg");
                    images.Add("/images/Hafezieh Prayer Room/render/hafezieh prayer room   (7).jpg");
                    break;

            }

            List<Card> cards = new List<Card>();

            for (int i = 0; i < images.Count; i++)
            {
                cards.Add(new Card
                {
                    name = "name " + i,
                    src = images[i],
                    //text = "Hala ye chizi baw.",
                    //title = "inam az title " + id
                });
            }

            return View(cards);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
