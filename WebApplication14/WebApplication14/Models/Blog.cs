using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication14.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public string Icerik { get; set; }
        public DateTime EkelemTarihi { get; set; }
        public bool Onay { get; set; }
        public bool  Anasayfa { get; set; }



        public int CategoriId { get; set; }
        public Category Category { get; set; }
    }
}