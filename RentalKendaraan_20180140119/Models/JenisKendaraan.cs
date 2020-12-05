using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140119.Models
{
    public partial class JenisKendaraan
    {
        public int IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Nama jenis kendaraan tidak boleh kosong")]
        public string NamaJenisKendaraan { get; set; }

        public Kendaraan Kendaraan { get; set; }
    }
}
