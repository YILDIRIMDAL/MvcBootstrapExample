using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcyeBootstrap314EklemeDenemesi.Models
{
    public class Haber
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string İcerik { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public string FotoUrl { get; set; }
        public string FotoUrl2 { get; set; }
        public string FotoUrl3 { get; set; }
        public string FotoUrl4 { get; set; }
        public string FotoUrl5 { get; set; }
    }
}