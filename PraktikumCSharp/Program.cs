using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PraktikumCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Membuat objek Mahasiswa di memori
            var mhs = new Mahasiswa(
                214001, 
                "Anindita Bunkal", 
                "Teknologi Informasi", 
                new List<string> { "Pemrograman Jaringan", "Sistem Operasi", "Jaringan Komputer" }
            );

            Console.WriteLine("=== 1. DATA ASLI DI MEMORI ===");
            mhs.TampilkanInfo();

            // 2. Serialisasi Objek ke JSON String
            string jsonString = JsonSerializer.Serialize(mhs, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine("=== 2. HASIL SERIALISASI JSON ===");
            Console.WriteLine(jsonString);

            // 3. TUGAS MANDIRI: Menyimpan JSON string ke berkas fisik (.json) menggunakan File Stream
            File.WriteAllText("mahasiswa.json", jsonString);
            Console.WriteLine("\n[Info] Berkas 'mahasiswa.json' berhasil disimpan ke storage.");

            // 4. TUGAS MANDIRI: Membaca kembali berkas fisik tersebut sebelum dideserialisasi
            string fileDataRead = File.ReadAllText("mahasiswa.json");
            Console.WriteLine("\n=== 3. MEMBACA KEMBALI DARI BERKAS FISIK (STORAGE) ===");
            Console.WriteLine(fileDataRead);

            // 5. Proses Deserialisasi (Mengubah teks JSON dari file kembali menjadi objek utuh)
            Mahasiswa? mhsFromJson = JsonSerializer.Deserialize<Mahasiswa>(fileDataRead);
            if (mhsFromJson != null)
            {
                Console.WriteLine("=== 4. HASIL DESERIALISASI KEMBALI KE OBJEK ===");
                mhsFromJson.TampilkanInfo();
            }
        }
    }
}