using ASP.NETCOREMVCKitap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP.NETCOREMVCKitap.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Index()
        {
            //JOIN olmadan...
            //return View(KitapDB.Kitaplar);

            //JOIN ile...
            var liste = from k in KitapDB.Kitaplar
                        join y in KitapDB.Yazarlar
                        on k.YazarID equals y.YazarID
                        join kat in KitapDB.Kategoriler
                        on k.KategoriID equals kat.KategoriID
                        select new Kitap_VM
                        {
                            KitapID = k.KitapID,
                            KitapAdi = k.KitapAdi,
                            Yazar = y.YazarAdSoyad,
                            Kategori = kat.KategoriAdi,
                            Fiyat = k.Fiyat
                        };


            return View(liste.ToList());
        }

        public IActionResult ResimIleListele()
        {
            //JOIN olmadan...
            //return View(KitapDB.Kitaplar);

            //JOIN ile...
            var liste = from k in KitapDB.Kitaplar
                        join y in KitapDB.Yazarlar
                        on k.YazarID equals y.YazarID
                        join kat in KitapDB.Kategoriler
                        on k.KategoriID equals kat.KategoriID
                        select new Kitap_VM
                        {
                            KitapID = k.KitapID,
                            KitapAdi = k.KitapAdi,
                            Yazar = y.YazarAdSoyad,
                            Kategori = kat.KategoriAdi,
                            Fiyat = k.Fiyat,
                            FilePath = k.FilePath
                        };


            return View(liste.ToList());
        }

        //[HttpGet]
        public IActionResult KitapEklemeSayfasi()
        {
            //Veri Giriş sayfasını goster...
            KitapEkle_VM kitapVM = new KitapEkle_VM();
            kitapVM.Kategoriler = new SelectList(KitapDB.Kategoriler, "KategoriID", "KategoriAdi");
            kitapVM.Yazarlar = new SelectList(KitapDB.Yazarlar, "YazarID", "YazarAdSoyad");

            return View(kitapVM);
        }

        [HttpPost]
        public IActionResult KitapEkle(Kitap kitap)
        {
            //Gelen verileri al ve kaydet...
            kitap.KitapID = KitapDB.Identity;
            KitapDB.Kitaplar.Add(kitap);
            // return Content("Veri kaydedilecek...");
            return RedirectToAction("Index");
        }

        public IActionResult ResimIleKitapEklemeSayfasi()
        {
            //Veri Giriş sayfasını goster...
            KitapEkle_VM kitapVM = new KitapEkle_VM();
            kitapVM.Kategoriler = new SelectList(KitapDB.Kategoriler, "KategoriID", "KategoriAdi");
            kitapVM.Yazarlar = new SelectList(KitapDB.Yazarlar, "YazarID", "YazarAdSoyad");

            return View(kitapVM);
        }

        [HttpPost]
        public IActionResult ResimIleKitapEkle(Kitap kitap)
        {
            //Gelen verileri al ve kaydet...
            kitap.KitapID = KitapDB.Identity;

            //ResimDosyasini sunucaya kaydet...

            string guid = Guid.NewGuid().ToString() + "_" + kitap.File.FileName
                ;
            //string strFilePath = "wwwroot/KapakResimleri/"+   kitap.File.FileName;
            string strFilePath = "wwwroot/KapakResimleri/" + guid;
            FileStream fs = new FileStream(strFilePath, FileMode.Create);
            kitap.File.CopyTo(fs);
            fs.Close();
            //kitap.FilePath = strFilePath;
            kitap.FilePath = guid;

            KitapDB.Kitaplar.Add(kitap);
            // return Content("Veri kaydedilecek...");
            return RedirectToAction("ResimIleListele");
        }
    }
}
