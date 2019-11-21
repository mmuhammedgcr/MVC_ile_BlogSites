using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication14.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            base.Seed(context);

            List<Category> Kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="C#"},
                 new Category() { KategoriAdi = "ASP#" },
                new Category(){KategoriAdi="HTML"},
                new Category(){KategoriAdi="CSS"},
                 new Category(){KategoriAdi="mvc"},

            };

            foreach (var item in Kategoriler)
            {
                context.Kategoriler.Add(item);
            }

            context.SaveChanges();



            List<Blog> Bloglar = new List<Blog>()
            {
                new Blog(){Baslik="C# Hakkında Bilinenler", Aciklama="C# Hakkında BilinenlerC# Hakkında Bilinenler",EkelemTarihi=DateTime.Now.AddDays(-7), Anasayfa=true, Onay=true,Icerik="C# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında Bilinenler",Resim="1.jpg",CategoriId=1},
                new Blog(){Baslik="asp Hakkında Bilinenler", Aciklama="C# Hakkında BilinenlerC# Hakkında Bilinenler",EkelemTarihi=DateTime.Now.AddDays(-2), Anasayfa=false, Onay=false,Icerik="C# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında Bilinenler",Resim="3.jpg",CategoriId=2},
                new Blog(){Baslik="HTML Hakkında Bilinenler", Aciklama="C# Hakkında BilinenlerC# Hakkında Bilinenler",EkelemTarihi=DateTime.Now.AddDays(-7), Anasayfa=true, Onay=true,Icerik="C# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında Bilinenler",Resim="2.jpg",CategoriId=3},
                new Blog(){Baslik="CSS Hakkında Bilinenler", Aciklama="C# Hakkında BilinenlerC# Hakkında Bilinenler",EkelemTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=false,Icerik="C# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında Bilinenler",Resim="1.jpg",CategoriId=4},
                new Blog(){Baslik="C# Hakkında Bilinenler", Aciklama="C# Hakkında BilinenlerC# Hakkında Bilinenler",EkelemTarihi=DateTime.Now.AddDays(-4), Anasayfa=true, Onay=true,Icerik="C# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında Bilinenler",Resim="4.jpg",CategoriId=5},
                new Blog(){Baslik="C# Hakkında Bilinenler", Aciklama="C# Hakkında BilinenlerC# Hakkında Bilinenler",EkelemTarihi=DateTime.Now.AddDays(-3), Anasayfa=true, Onay=true,Icerik="C# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında Bilinenler",Resim="1.jpg",CategoriId=6},
                new Blog(){Baslik="mvc Hakkında Bilinenler", Aciklama="C# Hakkında BilinenlerC# Hakkında Bilinenler",EkelemTarihi=DateTime.Now.AddDays(-3), Anasayfa=true, Onay=true,Icerik="C# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında BilinenlerC# Hakkında Bilinenler",Resim="1.jpg",CategoriId=6},
            };

            foreach (var item in Bloglar)
            {
                context.Bloglar.Add(item);

            }
            context.SaveChanges();
    }
    }
}