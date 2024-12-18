# Patungan
Aplikasi Pembantu Manajemen Stok dan Transaksi Toko Bangunan

## Deskripsi Proyek
Proyek ini adalah implementasi dari berbagai konsep Pemrograman Berorientasi Objek (PBO) menggunakan bahasa C#. 
Proyek ini dibuat sebagai tugas akhir dari mata kuliah PBO. Sistem yang dibuat merupakan sistem Point Of Sales (POS) toko bangunan.

## Tabel User Stories
| Kode | Judul                         | Story                                                                                                                                                       |
|------|-------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------|
| US001| Login                         | Pengguna sistem yaitu admin dan owner memasukkan informasi login yaitu username dan password.                                                               |
| US002| Melihat data profil           | Pengguna sistem yaitu admin dan owner dapat melihat data profil admin dan owner itu sendiri.                                                                |
| US003| Mengubah data profil          | Pengguna sistem yaitu admin, dan owner dapat mengubah data profil admin dan owner itu sendiri.                                                              |
| OW001| Menambahkan data barang       | Pengguna sistem yaitu owner menambahkan barang baru dengan keterangan nama barang, kategori, harga, jumlah, waktu pembelian, tanggal expired, dan foto barang|
| US004| Melihat data barang           | Pengguna sistem yaitu admin dan owner dapat melihat data barang.                                                                                            |
| OW002| Mengubah data barang          | Pengguna sistem yaitu owner dapat mengubah data barang yang sudah ada.                                                                                      |
| US005| Pencarian barang              | Pengguna sistem yaitu admin dan owner dapat melakukan pencarian barang dalam sistem.                                                                        |
| US006| Menambahkan data Transaksi    | Pengguna sistem yaitu admin dan owner dapat menambahkan data transaksi baru dengan keterangan tanggal transaksi, nama barang, jumlah, dan total.            |
| OW003| Melihat data laporan transaksi| Pengguna sistem yaitu owner dapat melihat data laporan dari transaksi yang sudah ada.                                                                       |
| OW004| Menambahkan data akun admin   | Pengguna sistem yaitu owner dapat menambahkan informasi akun baru yaitu username dan password.                                                              |
| OW005| Melihat data akun admin       | Pengguna sistem yaitu owner dapat melihat informasi biodata admin                                                                                           |
| OW006| Mengubah data akun admin      | Pengguna sistem yaitu owner dapat mengubah informasi biodata admin                                                                                          |

## Instalasi
1. Clone repositori ini:
    ```bash
    git clone https://github.com/Saptamabar/PBO_B1.git
    ```
2. Buka proyek di Visual Studio.
3. Buka PGAdmin 4 Kemudian buat sebuah database bernama 'Patungan'
4. Restore isi dari database menggunakan file bernama 'Patungan.sql'
5. Buka file DatabaseWrapper.cs Ubah username dan password database sesuai dengan akun postgreSQL anda
6. Bangun dan jalankan proyek.

## Penggunaan
1. Ketika di halaman login anda dapat melakukan login dengan akun owner yang memiliki username dan password.
- Username : owner
- Password : pass123
2. Anda dapat menambahkan barang terlebih dahulu, kemudian menambahkan transaksi untuk mengakses fitur lainnya
