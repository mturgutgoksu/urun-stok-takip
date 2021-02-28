using System;
using System.Collections.Generic;
using UrunStokTakip.Models;

namespace UrunStokTakip.UrunData
{
    interface UrunInterface
    {
        List<Urun> GetUrunler();

        Urun GetUrun(int id);
        Urun AddUrun(Urun urun);
        void DeleteUrun(Urun urun);
        Urun EditUrun(Urun urun);
    }
}
