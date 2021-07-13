using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> list = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        Environment.Exit(0);
                        return;

                    default:

                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih menu aplikasi\n");
            Console.WriteLine("1. Tambah mahasiswa");
            Console.WriteLine("2. Hapus Mahasiswa");
            Console.WriteLine("3. Tampilkan Mahasiswa");
            Console.WriteLine("4. Keluar\n");

        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            string NIM;
            string NAMA;
            string JK;
            string IPK;

            Console.Write("NIM: ");
            NIM = Console.ReadLine();
            Console.Write("Nama: ");
            NAMA = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P]: ");
            JK = Console.ReadLine();
            if (JK.Equals("L", StringComparison.InvariantCultureIgnoreCase))
            {
                JK = "Laki-Laki";
            }
            else
            {
                JK = "Perempuan";
            }
            Console.Write("IPK: ");
            IPK = Console.ReadLine();

            list.Add(new Mahasiswa(NIM, NAMA, JK, IPK));

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection
            Console.Clear();

            string cari;

            Console.WriteLine("Hapus data mahasiswa \n");

            Console.Write("NIM: ");
            cari = Console.ReadLine();

            int idx = list.FindIndex(a => a.nim.Equals(cari));

            if (idx == -1)
            {
                Console.WriteLine("NIM Tidak ditemukan");
            }
            else
            {
                list.RemoveAt(idx);
                Console.WriteLine("Data mahasiswa berhasil dihapus");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            Console.Clear();

            Console.WriteLine("Daftar Mahasiswa: \n");

            int number = 1;

            foreach (var mahasiswa in list)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", number, mahasiswa.nim, mahasiswa.nama, mahasiswa.kelamin, mahasiswa.ipk);


                number++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
