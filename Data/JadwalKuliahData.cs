using DashboardMahasiswa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardMahasiswa.Data
{
    public static class JadwalKuliahData
    {
        public static Dictionary<string, List<JadwalKuliah>> Jadwal = new Dictionary<string, List<JadwalKuliah>>
        {
            ["Senin"] = new List<JadwalKuliah>
            {
                new JadwalKuliah { Jam = "10:15", MataKuliah = "Sistem Digital", Ruangan = "R 2.2" },
                new JadwalKuliah { Jam = "13:15", MataKuliah = "Matematika Diskrit", Ruangan = "R 2.18" }
            },
            ["Selasa"] = new List<JadwalKuliah>
            {
                new JadwalKuliah { Jam = "10:15", MataKuliah = "Algoritma dan Struktur Data I", Ruangan = "Labor L 1.9" }
            },
            ["Rabu"] = new List<JadwalKuliah>
            {
                new JadwalKuliah { Jam = "09:30", MataKuliah = "Kecakapan Antar Personal", Ruangan = "R 2.15" },
                new JadwalKuliah { Jam = "14:00", MataKuliah = "Pendidikan Kewarganegaraan", Ruangan = "R 2.13" }
            },
            ["Kamis"] = new List<JadwalKuliah>
            {
                new JadwalKuliah { Jam = "11:00", MataKuliah = "Bahasa Inggris II", Ruangan = "R 2.16" }
            },
            ["Jumat"] = new List<JadwalKuliah>
            {
                new JadwalKuliah { Jam = "09:30", MataKuliah = "Kalkulus II", Ruangan = "R 2.17" }
            },
            ["Sabtu"] = new List<JadwalKuliah>
            {
                new JadwalKuliah { Jam = "10:15", MataKuliah = "Pemrograman Berbasis Objek", Ruangan = "Labor L 1.9" }
            },
            ["Minggu"] = new List<JadwalKuliah>() // Kosong (libur)
        };
    }
}