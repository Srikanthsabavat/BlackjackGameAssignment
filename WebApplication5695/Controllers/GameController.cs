using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5695.Migrations;
using WebApplication5695.Models;

namespace WebApplication5695.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        Context BL = new Context();


        public ActionResult Index()
        {
            return View();
        }
       
            public ActionResult GameStart()
        {
            CardAdding ca = new CardAdding();
            TempData["Player1"] = ca.PlayerCard();
            TempData["Player2"] = ca.PlayerSecondCard();
            TempData["Dealer1"] = ca.DealerCards();
            return View();
        }

       

        public ActionResult Hit()
        {
            HitMethod hm = new HitMethod();
            if (gs.PlayerHit < 1)
            {
               TempData["P_Hit1"] = hm.PlayerHit();

                gs.PlayerHit = gs.PlayerHit + 1;
            }



            else if (gs.PlayerHit < 2)
            {
                TempData["P_Hit2"] = hm.PlayerHit();
                gs.PlayerHit = gs.PlayerHit + 1;
            }

            else if (gs.PlayerHit < 3)
            {
                TempData["P_Hit3"] = hm.PlayerHit();
            }
            return View("GameStart");
        }





        public ActionResult Stand()
        {
            HitMethod hm = new HitMethod();
            GameStatus PG = new GameStatus();


            while (gs.DealerHandvalue <= 17)
            {
                if (gs.DealerHit < 1)
                {
                    TempData["D_Hit1"] = hm.DealerHit();
                    gs.DealerHit = gs.DealerHit + 1;
                }

                else if (gs.DealerHit < 2)
                {
                    TempData["D_Hit2"] = hm.DealerHit();
                    gs.DealerHit = gs.DealerHit + 1;
                }
                else if (gs.DealerHit < 3)
                {
                    TempData["D_Hit3"] = hm.DealerHit();
                    gs.DealerHit = gs.DealerHit + 1;
                }
                else if (gs.DealerHit < 4)
                {
                    TempData["D_Hit4"] = hm.DealerHit();
                }
            }
            if (gs.DealerHandvalue >= 17)
            {
                ViewData["GameStatus"] = PG.CheckGame();
            }
            return View("GameStart");
        }


        public ActionResult PlayAgain()
        {
            GameRestart GR = new GameRestart();
              GR.Restart();
              TempData.Remove("P_hit1");
              TempData.Remove("P_hit2");
              TempData.Remove("P_hit3");
              TempData.Remove("D_hit1");
              TempData.Remove("D_hit2");
              TempData.Remove("D_hit3");
              TempData.Remove("D_hit4");
            return RedirectToAction("Index");


        }
        public ActionResult SessionReport()
        {
            List<Session> se = BL.Sessions.ToList();
            return View(se);
        }
        public ActionResult GameSave()
        {
            GameStatus pg = new GameStatus();
            Session se = new Session();
            se.PlayerTotal = gs.PlayerHandvalue;
            se.DealerTotal = gs.DealerHandvalue;

            se.GameResult = pg.CheckGame();
            BL.Sessions.Add(se);
            BL.SaveChanges();
            return View("GameStart");
        }



    }
}