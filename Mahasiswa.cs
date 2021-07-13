using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    public class Mahasiswa
    {
        public string nim;
        public string nama;
        public string kelamin;
        public string ipk;

        public Mahasiswa(string nim, string nama, string kelamin, string ipk)
        {
            this.nim = nim;
            this.nama = nama;
            this.kelamin = kelamin;
            this.ipk = ipk;
        }
    }
}