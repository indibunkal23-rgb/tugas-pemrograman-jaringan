using System;
using System.Collections.Generic;

namespace PraktikumStream
{
    [Serializable]
    public class Mahasiswa
    {
        public int NIM { get; set; }
        public string Nama { get; set; }
        public string Jurusan { get; set; }
        public List<string> Matakuliah { get; set; }

        public Mahasiswa() { }

        public Mahasiswa(int nim, string nama, string jurusan, List<string> matkul)
        {
            NIM = nim;
            Nama = nama;
            Jurusan = jurusan;
            Matakuliah = matkul;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"NIM     : {NIM}");
            Console.WriteLine($"Nama    : {Nama}");
            Console.WriteLine($"Jurusan : {Jurusan}");
            Console.WriteLine($"Matkul  : {string.Join(", ", Matakuliah)}");
            Console.WriteLine("--------------------");
        }
    }
}
```[cite: 23]

---

### Langkah 4: Implementasi Serialisasi JSON & XML di `Program.cs`
Buka file **`Program.cs`** bawaan proyek, hapus seluruh isinya, lalu ganti dengan kode pengujian serialisasi JSON & XML berikut:

```csharp
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Xml.Serialization;
using System.IO;

namespace PraktikumStream
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Membuat objek Mahasiswa di memori
            var mhs = new Mahasiswa(
                2413131001, 
                "Anindita Bunkal", 
                "Teknologi Informasi", 
                new List<string> { "Pemrograman Jaringan", "Sistem Operasi", "Jaringan Komputer" }
            );

            Console.WriteLine("=== DATA ASLI DI MEMORI ===");
            mhs.TampilkanInfo();

            // 2. Serialisasi ke JSON
            string jsonString = JsonSerializer.Serialize(mhs, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine("\n=== HASIL SERIALISASI JSON ===");
            Console.WriteLine(jsonString);

            // 3. Deserialisasi kembali dari JSON
            Mahasiswa mhsFromJson = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
            Console.WriteLine("\n=== HASIL DESERIALISASI JSON KE OBJEK ===");
            mhsFromJson.TampilkanInfo();
        }
    }
}