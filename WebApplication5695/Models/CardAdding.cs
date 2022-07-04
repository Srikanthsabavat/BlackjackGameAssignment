using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5695.Models
{
    public class CardAdding
    {
        public string PlayerCard1 { get; set; }
        public string PlayerCard2 { get; set; }
        public string DealerCard { get; set; }

        MixingCards mc = new MixingCards();

        public string PlayerCard()
        {
            mc.RandomCards();
            PlayerCard1 = mc.cardsName;
            gs.PlayerHandvalue = gs.PlayerHandvalue + mc.cardsValue;

            return PlayerCard1;
        }

        public string PlayerSecondCard()
        {
            mc.RandomCards();
            PlayerCard2 = mc.cardsName;
            gs.PlayerHandvalue = gs.PlayerHandvalue + mc.cardsValue;

            return PlayerCard2;
        }


        public string DealerCards()
        {
            mc.RandomCards();
            DealerCard = mc.cardsName;
            gs.DealerHandvalue = gs.DealerHandvalue + mc.cardsValue;

            return DealerCard;
        }

    }
}