using System.Reflection.Metadata;

namespace modul10_130220072
{
    public class Mahasiswa
    {
        public string nama { get; set; }
        public string nim { get; set; }
        public List<string> courses { get; set; }
        public int year { get; set; }

        public Mahasiswa(string nama, string nim, List<string> courses, int year)
        {
            this.nama = nama;
            this.nim = nim;
            this.courses = courses;
            this.year = year;
        }
    }
}
