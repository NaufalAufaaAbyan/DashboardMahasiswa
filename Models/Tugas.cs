using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardMahasiswa.Models
{
    public class Tugas
    {
        public string MataKuliah { get; set; }
        public string Deskripsi { get; set; }
        public DateTime Deadline { get; set; }
        public bool Selesai { get; set; }
    }
}