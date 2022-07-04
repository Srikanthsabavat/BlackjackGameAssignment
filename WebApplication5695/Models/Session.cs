using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5695.Models
{
    public class Session
    {
        [Key]
        public int GameNo { get; set; }
        public Nullable<int> PlayerTotal { get; set; }
        public Nullable<int> DealerTotal { get; set; }
        public string GameResult { get; set; }

    }
}