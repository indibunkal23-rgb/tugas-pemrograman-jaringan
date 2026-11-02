const fs = require('fs');

// Objek Mahasiswa
const mahasiswa = {
    nim: 24131310015,
    nama: "Anindita Bunkal",
    jurusan: "Teknologi Informasi",
    matakuliah: ["Pemrograman Jaringan", "Sistem Operasi", "Jaringan Komputer"]
};

// 1. Serialisasi Objek ke JSON string & Simpan ke Berkas Fisik (.json)
const jsonString = JSON.stringify(mahasiswa, null, 2);
fs.writeFileSync('mahasiswa.json', jsonString, 'utf8');
console.log("Data berhasil diserialisasi dan disimpan ke file 'mahasiswa.json'.\n");

// 2. Membaca kembali berkas menggunakan File Stream/Read
const fileDataRead = fs.readFileSync('mahasiswa.json', 'utf8');
console.log("--- ISI FILE YANG DIBACA DARI STORAGE ---");
console.log(fileDataRead);

// 3. Proses Deserialisasi (Mengembalikan teks JSON dari file menjadi objek utuh)
const mahasiswaDeserialized = JSON.parse(fileDataRead);
console.log("\n--- HASIL DESERIALISASI OBJEK ---");
console.log(`NIM     : ${mahasiswaDeserialized.nim}`);
console.log(`Nama    : ${mahasiswaDeserialized.nama}`);
console.log(`Jurusan : ${mahasiswaDeserialized.jurusan}`);
console.log(`Matkul  : ${mahasiswaDeserialized.matakuliah.join(', ')}`);