using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrunStokTakip.Models
{
    public class UrunContext: DbContext
    {
        public UrunContext(DbContextOptions<UrunContext> options) : base(options)
        {

        }
        public DbSet<Urun> Urunler { get; set; }
    }
}
