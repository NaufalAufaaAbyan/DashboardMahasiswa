using System;
using System.Linq;
using DashboardMahasiswa.Helpers;

namespace DashboardMahasiswa.Features
{
    public static class ReminderTugas
    {
        public static void TampilkanPengingat()
        {
            UIHelper.ShowHeader("⏰ PENGINGAT TUGAS TERDEKAT");

            var tugasTerdekat = Storage.SemuaTugas
                .Where(t => !t.Selesai)
                .OrderBy(t => t.Deadline)
                .Take(2)
                .ToList();

            if (tugasTerdekat.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("🎉 Tidak ada tugas mendesak!");
                Console.ResetColor();
                return;
            }

            foreach (var tugas in tugasTerdekat)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"📌 {tugas.MataKuliah} - {tugas.Deskripsi}");
                Console.WriteLine($"   Deadline: {tugas.Deadline:yyyy-MM-dd}");
                Console.ResetColor();
            }
        }
    }
}