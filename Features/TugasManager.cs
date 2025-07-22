using System;
using DashboardMahasiswa.Helpers;
using DashboardMahasiswa.Models;

namespace DashboardMahasiswa.Features
{
    public static class TugasManager
    {
        public static void TambahTugas()
        {
            UIHelper.ShowHeader("➕ TAMBAH TUGAS");

            Console.Write("📘 Mata Kuliah: ");
            string mk = Console.ReadLine();

            Console.Write("📝 Deskripsi Tugas: ");
            string desc = Console.ReadLine();

            Console.Write("📅 Deadline (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime deadline))
            {
                Storage.SemuaTugas.Add(new Tugas
                {
                    MataKuliah = mk,
                    Deskripsi = desc,
                    Deadline = deadline,
                    Selesai = false
                });


                Storage.SimpanTugas(Storage.SemuaTugas);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("✅ Tugas berhasil ditambahkan!");
                Console.ResetColor();
            }
            else
            {
                UIHelper.ShowError("Format tanggal tidak valid!");
            }
        }

        public static void TampilkanSemuaTugas()
        {
            UIHelper.ShowHeader("📋 DAFTAR TUGAS");

            if (Storage.SemuaTugas.Count == 0)
            {
                Console.WriteLine("📭 Belum ada tugas.");
                return;
            }

            int i = 1;
            foreach (var tugas in Storage.SemuaTugas)
            {
                Console.ForegroundColor = tugas.Selesai ? ConsoleColor.Green : ConsoleColor.Red;
                string status = tugas.Selesai ? "✔ Selesai" : "❌ Belum";
                Console.WriteLine($"{i++}. {tugas.MataKuliah} | {tugas.Deskripsi} | {tugas.Deadline:yyyy-MM-dd} | {status}");
                Console.ResetColor();
            }
        }

        public static void TandaiTugasSelesai()
        {
            TampilkanSemuaTugas();
            Console.Write("\n🆗 Pilih nomor tugas yang sudah selesai: ");
            if (int.TryParse(Console.ReadLine(), out int no) && no >= 1 && no <= Storage.SemuaTugas.Count)
            {
                Storage.SemuaTugas[no - 1].Selesai = true;
                Storage.SimpanTugas(Storage.SemuaTugas);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("✅ Tugas ditandai selesai!");
                Console.ResetColor();
            }
            else
            {
                UIHelper.ShowError("Nomor tugas tidak valid!");
            }
        }

        public static void HapusTugas()
        {
            TampilkanSemuaTugas();
            Console.Write("\n🗑 Pilih nomor tugas yang ingin dihapus: ");
            if (int.TryParse(Console.ReadLine(), out int no) && no >= 1 && no <= Storage.SemuaTugas.Count)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"⚠ Anda yakin ingin menghapus tugas \"{Storage.SemuaTugas[no - 1].MataKuliah}\"?");
                Console.ResetColor();
                Console.Write("Ketik 'y' untuk konfirmasi: ");
                string confirm = Console.ReadLine().ToLower();

                if (confirm == "y")
                {
                    Storage.SemuaTugas.RemoveAt(no - 1);
                    Storage.SimpanTugas(Storage.SemuaTugas);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("✅ Tugas berhasil dihapus!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("❎ Dibatalkan.");
                }

                Console.ResetColor();
            }
            else
            {
                UIHelper.ShowError("Nomor tugas tidak valid!");
            }
        }
    }
}