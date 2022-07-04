using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5695.Models
{
     public class GameStatus
    {
        public string CheckGame()
        {
            if(gs.PlayerHandvalue<21 && gs.PlayerHandvalue<gs.DealerHandvalue)
            {
                return "PlayerWin";

            }
            else if(gs.DealerHandvalue<21 && gs.DealerHandvalue<gs.PlayerHandvalue)
            {
                return "DealerWin";
            }
            else if(gs.PlayerHandvalue == gs.DealerHandvalue)
            {
                return "Tie";
            }
           
            return "No One win beacause PlayerScore and DealerScore is above 21 ";
        }

    }
}