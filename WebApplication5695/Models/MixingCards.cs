using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5695.Migrations;
using WebApplication5695.Models;

namespace WebApplication5695.Models
{
    public class MixingCards
    {
        public string cardsName { get; set; }
        public int cardsValue { get; set; }

        public void RandomCards()
        {

            Context c = new Context();
            List<Card> card = c.Cards.ToList();

            Random random = new Random(Guid.NewGuid().GetHashCode());
            int r = random.Next(card.Count);
            var res = card[r].CardName.ToString();
            cardsValue = card[r].CardValue.Value;
            cardsName = res;

        }
    }
}