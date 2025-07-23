# 🎓 Dashboard Mahasiswa - C# Console App (.NET Framework 4.8.1)

Proyek ini adalah aplikasi *Dashboard Mahasiswa berbasis C# Windows Console App* menggunakan *.NET Framework 4.8.1*, yang dibuat sebagai tugas UAS mata kuliah Pemrograman Berbasis Objek.

---

## 📌 Fitur Utama

| No | Fitur | Keterangan |
|----|-------|------------|
| 1️⃣ | Dashboard Hari Ini | Menampilkan jadwal kuliah hari ini berdasarkan hari realtime |
| 2️⃣ | Tambah Tugas | Menambahkan tugas baru (Mata Kuliah, Deskripsi, Deadline) |
| 3️⃣ | Tampilkan Semua Tugas | Menampilkan seluruh daftar tugas dengan status selesai/belum |
| 4️⃣ | Tandai Tugas Selesai | Mengubah status tugas menjadi selesai |
| 5️⃣ | Hapus Tugas | Menghapus tugas dari daftar |
| 6️⃣ | Reminder Tugas Terdekat | Mengingatkan tugas yang paling dekat deadline-nya |
| 7️⃣ | Lihat Jadwal Kuliah | Menampilkan seluruh jadwal kuliah semester berjalan |

---

## 🗂 Struktur Folder

DashboardMahasiswa/
│
├── Models/
│   └── Tugas.cs
│
├── Data/
│   └── JadwalKuliah.cs
│
├── Features/
│   ├── JadwalHariIni.cs
│   ├── ReminderTugas.cs
│   └── TugasManager.cs
│
├── Helpers/
│   ├── Storage.cs
│   └── UIHelper.cs
│
├── Tugas/
│   └── Tugas.json         ← Tempat penyimpanan data tugas
│
├── Program.cs             ← Entry point program
├── README.md              ← File dokumentasi proyek
└── .gitignore             ← File pengecualian Git (jika ada)



- Program akan me-load ulang data setiap kali dijalankan.
- Format file: JSON

---

Pastikan folder `Daftar_Tugas` sudah dibuat, atau akan otomatis dibuat oleh program.

---

## 🔧 Teknologi & Tools

| Komponen               | Keterangan                                |
|------------------------|--------------------------------------------|
| 💻 Bahasa              | C#                                         |
| 📦 Framework           | .NET Framework 4.8.1                       |
| ⚙️ Tipe Project         | Windows Console App                        |
| 📚 Library (NuGet)     | `Newtonsoft.Json` (untuk JSON handling)   |
| 🛠️ IDE                 | Visual Studio 2022                         |

---

## 🚀 Cara Menjalankan

1. **Buka** proyek di Visual Studio 2022
2. Pastikan target framework adalah **.NET Framework 4.8.1**
3. Pastikan sudah install NuGet `Newtonsoft.Json`
4. Tekan `Ctrl + F5` atau klik `Start Without Debugging`
5. Jalankan program dan pilih menu dari terminal

---

## 📦 Cara Install Newtonsoft.Json

**Via NuGet GUI:**
- Klik kanan pada nama project → `Manage NuGet Packages`
- Cari `Newtonsoft.Json`
- Klik **Install**

**Via Package Manager Console:**
```powershell
Install-Package Newtonsoft.Json

---

## 📅 Jadwal Kuliah (Contoh Semester 2)

- *Senin*:
- Sistem Digital (10.15, R 2.2)
- Matematika Diskrit (13.15, R 2.18)
- *Selasa*:
- Algoritma & Struktur Data I (10.15, Labor L 1.9)
- *Rabu*:
- Kecakapan Antar Personal (09.30, R 2.15)
- Pendidikan Kewarganegaraan (14.00, R 2.13)
- *Kamis*:
- Bahasa Inggris II (11.00, R 2.16)
- *Jumat*:
- Kalkulus II (09.30, R 2.17)
- *Sabtu*:
- Pemrograman Berbasis Objek (10.15, Labor L 1.9)

---

## ✍ Kontributor

- 👤 Nama: *Naufal Aufaa Abyan*
- 👨‍🎓 Mahasiswa Semester 2
- 🎓 Proyek Tugas UAS - Pemrograman Berbasis Objek

---

🗂️ Lisensi

Project ini dibuat untuk keperluan edukasi. Bebas digunakan atau dimodifikasi.




