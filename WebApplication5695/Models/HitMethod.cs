using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5695.Models
{
    public class HitMethod
    {
        public string hitcard { get; set; }

        MixingCards mc = new MixingCards();

      
        public string PlayerHit()
        {
            if (gs.PlayerHandvalue <= 21)
            {
                mc.RandomCards();
                hitcard = mc.cardsName;
                gs.PlayerHandvalue = gs.PlayerHandvalue + mc.cardsValue;
            }
            else
            {
                return "NO CARDS";
            }
            return hitcard;
        }

       
        public string DealerHit()
        {
            if (gs.DealerHandvalue <= 17)
            {
                mc.RandomCards();
                hitcard = mc.cardsName;
                gs.DealerHandvalue = gs.DealerHandvalue + mc.cardsValue;
            }
            else
            {
                return "NO CARDS";
            }
            return hitcard;
        }

    }
}