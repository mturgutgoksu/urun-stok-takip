
using System;
using System.Collections.Generic;
using System.Linq;
using UrunStokTakip.Models;

namespace UrunStokTakip.UrunData
{
    public class UrunIslemleri : UrunInterface
    {
        private UrunContext _urunContext;
        public UrunIslemleri(UrunContext urunContext)
        {
            _urunContext = urunContext;
        }
        public Urun AddUrun(Urun urun)
        {
            var addUrun =_urunContext.Urunler.Add(urun);
            _urunContext.SaveChanges();
            return urun;
        }

        public void DeleteUrun(Urun urun)
        {
            var delUrun = _urunContext.Urunler.Find(urun);
            if(delUrun != null)
            {
                _urunContext.Urunler.Remove(delUrun);
            }
        }

        public Urun EditUrun(Urun urun)
        {
            var upUrun = _urunContext.Urunler.Find(urun.id);
            if(upUrun != null)
            {
                upUrun.Ad = urun.Ad;
                _urunContext.Urunler.Update(upUrun);
                _urunContext.SaveChanges();
            }
            return urun;

        }

        public Urun GetUrun(int id)
        {
            var urun = _urunContext.Urunler.Find(id);
            return urun;
        }

        public List<Urun> GetUrunler()
        {
            return _urunContext.Urunler.ToList();
        }
    }
}
