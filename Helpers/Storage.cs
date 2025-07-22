using DashboardMahasiswa.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DashboardMahasiswa.Helpers
{
    public static class Storage
    {
        private static string filePath = @"D:\02_Kuliah\Tugas\TUGAS PBO\DashboardMahasiswa\Daftar_Tugas\Tugas.json";
        public static List<Tugas> SemuaTugas = new List<Tugas>();

        public static void LoadTugas()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var json = File.ReadAllText(filePath);
                    SemuaTugas = JsonConvert.DeserializeObject<List<Tugas>>(json) ?? new List<Tugas>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Gagal memuat tugas: {ex.Message}");
                SemuaTugas = new List<Tugas>();
            }
        }

        public static void SimpanTugas(List<Tugas> tugas)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                string jsonData = JsonConvert.SerializeObject(tugas, Formatting.Indented);
                File.WriteAllText(filePath, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Gagal menyimpan tugas: {ex.Message}");
            }
        }
    }
}