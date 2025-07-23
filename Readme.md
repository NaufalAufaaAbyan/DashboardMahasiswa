# 🎓 Dashboard Mahasiswa - Console App (.NET Framework 4.8.1)

Aplikasi Konsol Sederhana untuk Mahasiswa yang dibuat menggunakan **C# Windows Console App (.NET Framework 4.8.1)**. Program ini memudahkan mahasiswa dalam mengelola **jadwal kuliah**, **tugas harian**, dan **pengingat tugas terdekat**, dengan penyimpanan otomatis ke file JSON.

---

## 📌 Fitur-Fitur

- 📅 **Jadwal Kuliah Hari Ini** (berdasarkan hari aktual)
- 📝 **Tambah Tugas Baru**
- 📋 **Lihat Semua Tugas**
- ✅ **Tandai Tugas Selesai**
- ⏰ **Reminder Tugas Terdekat**
- 🗓️ **Lihat Jadwal Semester Lengkap**
- 🗑️ **Hapus Tugas**
- 💾 **Simpan Data Tugas ke File JSON Otomatis**
- 🌈 Antarmuka Terminal Interaktif dengan Emoji & Animasi

---

## 📁 Struktur Folder Proyek
DashboardMahasiswa/
│
├── Program.cs
│
├── Models/
│   └── Tugas.cs
│
├── Data/
│   └── JadwalKuliahData.cs
│
├── Features/
│   ├── TugasManager.cs
│   ├── JadwalHariIni.cs
│   └── ReminderTugas.cs
│
├── Helpers/
│   ├── Storage.cs
│   └── UIHelper.cs
│
├── Daftar_Tugas/
│   └── Tugas.json

---

## 💾 Lokasi Penyimpanan Data

Data tugas akan otomatis disimpan ke file berikut:
...\...\...\Daftar_Tugas\Tugas.json

> 📌 Folder dan file akan dibuat otomatis jika belum ada.

---

## ⚙️ Teknologi & Library

| Komponen               | Keterangan                                |
|------------------------|--------------------------------------------|
| 💻 Bahasa              | C#                                         |
| 📦 Framework           | .NET Framework 4.8.1                       |
| 🖥️ Tipe Project        | Windows Console App                        |
| 📚 Library (NuGet)     | `Newtonsoft.Json`                         |
| 🛠️ IDE                 | Visual Studio 2022                         |

---

## 📦 Install Newtonsoft.Json

**Via NuGet GUI:**
- Klik kanan nama project → `Manage NuGet Packages`
- Cari `Newtonsoft.Json`
- Klik **Install**

**Via Package Manager Console:**
```powershell
Install-Package Newtonsoft.Json

🚀 Cara Menjalankan Proyek
	1.	Buka proyek di Visual Studio 2022
	2.	Pastikan project adalah Windows Console App (.NET Framework 4.8.1)
	3.	Pastikan Newtonsoft.Json sudah terinstal
	4.	Tekan Ctrl + F5 atau Start Without Debugging
	5.	Navigasi menu dari terminal dengan angka pilihan

📌 Catatan
	•	Data tugas bersifat persisten meskipun program ditutup
	•	Status jadwal kuliah (Tatap Muka / Online / Cancel) ditentukan secara acak setiap hari
	•	Program cocok untuk demo tugas UAS PBO

👤 Tentang
	•	Nama: Naufal Aufaa Abyan
	•	Mata Kuliah: Pemrograman Berbasis Objek
	•	Semester: 2

🗂️ Lisensi

Proyek ini dibuat untuk keperluan edukasi. Bebas digunakan dan dimodifikasi untuk pengembangan lebih lanjut.




