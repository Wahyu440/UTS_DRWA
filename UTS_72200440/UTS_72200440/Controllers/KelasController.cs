using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UTS_72200440.Models;

namespace UTS_72200440.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KelasController : ControllerBase
    {
        private KelasContext _context;

        public KelasController(KelasContext context)
        {
            this._context = context;
        }

        // GET: api/kelas
        [HttpGet]
        public ActionResult<IEnumerable<KelasItem>> GetSiswaItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(KelasContext)) as KelasContext;
            return _context.GetAllSiswa();
        }

        //Get : api/kelas/{id}
        [HttpGet("{id}", Name = "GetKelas")]
        public ActionResult<IEnumerable<KelasItem>> GetSiswaItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(KelasContext)) as KelasContext;
            return _context.GetSiswa(id);
        }

        [HttpPost]
        public ActionResult<KelasItem> AddKelas([FromForm] string kelas, [FromForm] string jurusan, [FromForm] int sub)
        {
            KelasItem KI = new KelasItem();
            KI.kelas = kelas;
            KI.jurusan = jurusan;
            KI.sub = sub;

            _context = HttpContext.RequestServices.GetService(typeof(KelasContext)) as KelasContext;
            return _context.AddKelas(KI);
        }
    }
}
