using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul10_130220072.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahsiswaController : ControllerBase
    {
        private static List<string> courses = new List<string>
        { "KPL", "BD", "PBO" };

        private static List<Mahasiswa> semuaMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Joshua Daniel Simanjuntak", "1302220072", courses, 2022),
            new Mahasiswa("Rakha Galih Nugraha Sukma", "1302223118", courses, 2022),
            new Mahasiswa("Mohammed Yousef Gumilar", "1302220085", courses, 2022),
            new Mahasiswa("Irvan Dzawin Nuha", "1302223076", courses, 2022),
            new Mahasiswa("Abdillah Aufa Taqiyya", "1302220131", courses, 2022)
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get() { return semuaMahasiswa; }

        [HttpPost]
        public void Post([FromBody] Mahasiswa newvalue)
        {
            semuaMahasiswa.Add(newvalue);
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return semuaMahasiswa[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            semuaMahasiswa.RemoveAt(id);
        }
    }
}
