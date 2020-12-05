using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140119.Models
{
    public partial class Gender
    {
        public int IdGender { get; set; }

        [Required(ErrorMessage = "Nama Gender tidak boleh kosong")]
        public string NamaGender { get; set; }

        public Customer IdGenderNavigation { get; set; }
    }
}
