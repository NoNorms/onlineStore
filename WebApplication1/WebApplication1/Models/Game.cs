using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Game
    {
        public int id { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public decimal price { get; set; }
    }
}