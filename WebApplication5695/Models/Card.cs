using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5695.Models
{
    public class Card
    {
        [Key]
        public int CardNo { get; set; }
        public string CardName { get; set; }
        public Nullable<int> CardValue { get; set; }

    }
}