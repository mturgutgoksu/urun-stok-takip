using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrunStokTakip.Models;
using UrunStokTakip.UrunData;

namespace UrunStokTakip.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
        public class UrunController : ControllerBase
    {
        private UrunIslemleri _urunContext;

        public UrunController(UrunIslemleri urunIslemleri)
        {
            _urunContext = urunIslemleri;
        }
        [HttpGet]
        public IActionResult GetUrunler()
        {
            return Ok(_urunContext.GetUrunler());
        }

        //[HttpGet]
        public IActionResult GetUrun(int id)
        {
            var urun = _urunContext.GetUrun(id);
            if( urun != null)
            {
                return Ok(urun);
            }
            return NotFound($"Urün ile id: {id} was not found");
        }

        [HttpPost]
        public IActionResult GetUrun(Urun urun)
        {
            _urunContext.AddUrun(urun);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/"
                + urun.id, urun);  
        }

        [HttpDelete]
        public IActionResult DeleteUrun(int id)
        {
            var urun = _urunContext.GetUrun(id);
            if (urun != null)
            {
                _urunContext.DeleteUrun(urun);

                return Ok();
            }
            return NotFound($"Urün ile id: {id} was not found");
        }

        [HttpPatch]
        public IActionResult EditUrun(int id, Urun urun)
        {
            var vUrun = _urunContext.GetUrun(id);
            if (urun != null)
            {
                urun.UUID = vUrun.UUID;
                _urunContext.EditUrun(urun);

                return Ok();
            }
            return Ok(urun);
            
        }
    }
}
