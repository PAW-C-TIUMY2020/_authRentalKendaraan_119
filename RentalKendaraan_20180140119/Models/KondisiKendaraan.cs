using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140119.Models
{
    public partial class KondisiKendaraan
    {
        public int IdKondisi { get; set; }

        [Required(ErrorMessage = "Nama kondisi tidak boleh kosong")]
        public string NamaKondisi { get; set; }

        public Pengembalian IdKondisiNavigation { get; set; }
    }
}
