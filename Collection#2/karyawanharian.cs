using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaji_karyawan
{
    class Karyawan_harian : Karyawan
    {
        public int Upah_perjam { get; set; }
        public int Jumlah_jamkerja { get; set; }
        public override int Gaji() => Upah_perjam * Jumlah_jamkerja;
    }
}
