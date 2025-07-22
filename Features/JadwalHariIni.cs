using System;
using DashboardMahasiswa.Data;
using DashboardMahasiswa.Helpers;

namespace DashboardMahasiswa.Features
{
    public static class JadwalHariIni
    {
        private static readonly Random rnd = new Random();

        public static void Tampilkan()
        {
            UIHelper.ShowHeader("📅 JADWAL HARI INI");
            string hari = DateTime.Now.DayOfWeek.ToString();
            // Replaced switch expression with switch statement for C# 7.3 compatibility
            switch (hari)
            {
                case "Monday":
                    hari = "Senin";
                    break;
                case "Tuesday":
                    hari = "Selasa";
                    break;
                case "Wednesday":
                    hari = "Rabu";
                    break;
                case "Thursday":
                    hari = "Kamis";
                    break;
                case "Friday":
                    hari = "Jumat";
                    break;
                case "Saturday":
                    hari = "Sabtu";
                    break;
                default:
                    hari = "Tidak ada kuliah";
                    break;
            }

            if (JadwalKuliahData.Jadwal.ContainsKey(hari))
            {
                foreach (var item in JadwalKuliahData.Jadwal[hari])
                {
                    string[] status = { "Online", "Tatap Muka", "Cancel" };
                    string randomStatus = status[rnd.Next(status.Length)];

                    Console.ForegroundColor = randomStatus == "Online" ? ConsoleColor.Cyan
                        : randomStatus == "Tatap Muka" ? ConsoleColor.Green
                        : randomStatus == "Cancel" ? ConsoleColor.Red
                        : ConsoleColor.White;

                    Console.WriteLine($"🕒 {item.Jam} | {item.MataKuliah} | {item.Ruangan} | {randomStatus}");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("📭 Tidak ada jadwal kuliah hari ini.");
            }
        }

        public static void TampilkanSemua()
        {
            UIHelper.ShowHeader("📚 JADWAL SEMESTER");
            foreach (var hari in JadwalKuliahData.Jadwal)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\n📆 {hari.Key}");
                Console.ResetColor();

                foreach (var matkul in hari.Value)
                {
                    Console.WriteLine($"  🕒 {matkul.Jam} - {matkul.MataKuliah} ({matkul.Ruangan})");
                }
            }
        }
    }
}