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

        public IActionResult Cards(int id)
        {
            ViewData["Message"] = "Your application description page.";
            List<Card> cards = new List<Card>();
            cards.Add(new Card{
                name="first",
                src="/images/7.37House and Studio/7.37House and Studio    (2).jpg",
                text="Hala ye chizi baw.",
                title="inam az title "+id
            });

            cards.Add(new Card{
                name="second",
                src="/images/7.37House and Studio/7.37House and Studio    (3).jpg",
                text="Hala ye chizi baw e dovom.",
                title="inam az title e dovom"
            });

            cards.Add(new Card{
                name="second",
                src="/images/7.37House and Studio/7.37House and Studio    (5).jpg",
                text="Hala ye chizi baw e dovom.",
                title="inam az title e dovom"
            });

            cards.Add(new Card{
                name="second",
                src="/images/7.37House and Studio/7.37House and Studio    (4).jpg",
                text="Hala ye chizi baw e dovom.",
                title="inam az title e dovom"
            });

            cards.Add(new Card{
                name="second",
                src="/images/7.37House and Studio/7.37House and Studio    (6).jpg",
                text="Hala ye chizi baw e dovom.",
                title="inam az title e dovom"
            });

            cards.Add(new Card{
                name="second",
                src="/images/7.37House and Studio/7.37House and Studio    (1).jpg",
                text="Hala ye chizi baw e dovom.",
                title="inam az title e dovom"
            });

            Card c = new Card();
            c.name="sdfsdf";
            c.src="kjudsfk";
            c.text="kldsds";
            c.title="jdbhfdjefbjds";

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
