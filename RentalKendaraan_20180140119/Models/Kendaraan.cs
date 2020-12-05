using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140119.Models
{
    public partial class Kendaraan
    {
        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }

        [MinLength(1, ErrorMessage = "Nomor Polisi minimal 1 angka")]
        [MaxLength(4, ErrorMessage = "Nomor Polisi maksimal 4 angka")]
        [RegularExpression("^[0-9]^$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        [Required(ErrorMessage = "Nomor Polisi wajib diisi")]
        public string NoPolisi { get; set; }

        [MinLength(7, ErrorMessage = "Nomor STNK minimal 7 angka")]
        [MaxLength(8, ErrorMessage = "Nomor STNK maksimal 8 angka")]
        [RegularExpression("^[0-9]^$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        [Required(ErrorMessage = "Nomor STNK wajib diisi")]
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Ketersediaan wajib diisi")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdKendaraanNavigation { get; set; }
        public Peminjaman Peminjaman { get; set; }
    }
}
