using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Website.Models
{
    [Table("Languages")]
    public class Language
    {
        [Key, Display(Name ="Language Code")]
        [Required]
        [StringLength(5)]
        public string LanguageCode { get; set; }

        [Display(Name ="English Name")]
        [Required]
        [StringLength(50)]
        public string EnglishLanguageName { get; set; }

        [Display(Name ="Native Language")]
        [Required]
        [StringLength(50)]
        public string NativeLanguageName { get; set; }
    }
}