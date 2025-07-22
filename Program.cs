using System;
using DashboardMahasiswa.Helpers;
using DashboardMahasiswa.Features;

namespace DashboardMahasiswa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "📚 Dashboard Mahasiswa";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            UIHelper.ShowWelcome();

            Storage.LoadTugas();

            while (true)
            {
                Console.Clear();
                UIHelper.DrawBox("📋 MENU UTAMA", new string[]
                {
                    "1️  Lihat Dashboard Hari Ini",
                    "2️  Tambah Tugas Baru",
                    "3️  Tampilkan Semua Tugas",
                    "4️  Tandai Tugas Selesai",
                    "5️  Hapus Tugas",
                    "6️  Reminder Tugas Terdekat",
                    "7️  Lihat Jadwal Kuliah Semester",
                    "0️  Keluar"
                });

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n>>> Pilih menu: ");
                Console.ResetColor();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1": JadwalHariIni.Tampilkan(); break;
                    case "2": TugasManager.TambahTugas(); break;
                    case "3": TugasManager.TampilkanSemuaTugas(); break;
                    case "4": TugasManager.TandaiTugasSelesai(); break;
                    case "5": TugasManager.HapusTugas(); break;
                    case "6": ReminderTugas.TampilkanPengingat(); break;
                    case "7": JadwalHariIni.TampilkanSemua(); break;
                    case "0":
                        Storage.SimpanTugas(Storage.SemuaTugas);
                        UIHelper.ShowExit();
                        return;
                    default:
                        UIHelper.ShowError("Input tidak valid!");
                        break;
                }

                UIHelper.Pause();
            }
        }
    }
}