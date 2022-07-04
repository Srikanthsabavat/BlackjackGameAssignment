using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5695.Models
{
    public class GameRestart
    {
       
        public void Restart()
        {
            gs gs = new gs();
            gs.PlayerHandvalue = 0;
            gs.DealerHandvalue = 0;
            gs.PlayerHit = 0;
            gs.DealerHit = 0;


        }

    }
}