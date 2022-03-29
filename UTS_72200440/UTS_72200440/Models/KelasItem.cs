namespace UTS_72200440.Models
{
    public class KelasItem
    {
        private KelasContext context;
        public int id_kelas { get; set; }
        public string kelas { get; set; }
        public string jurusan { get; set; }
        public int sub { get; set; }
    }
}
