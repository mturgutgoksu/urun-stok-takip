using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UrunStokTakip.Models
{
    public class Urun
    {
        internal object[] id;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UUID { get; set; }
        [Required]
        [MaxLength(150)]
        public string Ad { get; set; }

        [Required]
        public DateTime OlusturmaZamani { get; set; }
        
        public DateTime SilinmeZamani { get; set; }
        [Required]
        public Boolean SilindiMi { get; set; }
    }
}
