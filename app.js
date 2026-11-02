// ==========================================
// SISI PENGIRIM: OOP OBJECT & SERIALISASI
// ==========================================

// 1. Objek di Memori Pengirim
const userObjectPengirim = {
    nama: "INDI",
    foto: "profil_indi.png",
    daftarRiwayat: ["Login", "Beli Buku", "Logout"]
};

console.log("--- DI MEMORI PENGIRIM ---");
console.log("Tipe Data Asli:", typeof userObjectPengirim);
console.log("Isi Nama Objek:", userObjectPengirim.nama);

// 2. PROSES SERIALISASI (Mengubah objek menjadi format teks JSON)
const dataStreamText = JSON.stringify(userObjectPengirim);

console.log("\n--- DATA DI STREAM TRANSMISI (Bebas Platform) ---");
console.log("Tipe Data Sekarang:", typeof dataStreamText); // Berubah jadi string/teks
console.log("Format Teks yang Mengalir di Jaringan:", dataStreamText);

// ==========================================
// SISI PENERIMA: DESERIALISASI
// ==========================================

// 3. PROSES DESERIALISASI (Menyusun kembali teks JSON menjadi objek utuh)
const userObjectPenerima = JSON.parse(dataStreamText);

console.log("\n--- DI MEMORI PENERIMA ---");
console.log("Tipe Data Setelah Dirakit Kembali:", typeof userObjectPenerima);
console.log("Isi Nama Objek yang Diterima:", userObjectPenerima.nama);
