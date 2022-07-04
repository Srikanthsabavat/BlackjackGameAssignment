using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication5695.Models
{
    public class Context: DbContext
    {
        public Context() : base("name = BlackJackGame")
        {

        }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }

    }
}