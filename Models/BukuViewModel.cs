using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryWeb.Models
{
    public class BukuViewModel
    {
        [Required]
        [Display(Name = "ID Buku")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Judul Buku")]
        public string Judul { get; set; }

        [Required]
        [Display(Name = "Pengarang")]
        public string Pengarang { get; set; }
        
        [Required]
        [Display(Name = "Jenis Buku")]
        public string Jenis { get; set; }
        
        [Required]
        [Display(Name = "Harga Sewa/Hari")]
        public Decimal Sewa { get; set; }
    }
}