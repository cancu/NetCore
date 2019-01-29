using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{   
    public class CategoryVM
    {

        [Display(Name = "Id")]
        public int CategoryId { get; set; }
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Ad alanı zorunludur")]
        [StringLength(15, ErrorMessage = "{0} alanı {1} den uzun girilemez")]
        public string CategoryName { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Resim")]
        public IFormFile Picture { get; set; }

    }
}
