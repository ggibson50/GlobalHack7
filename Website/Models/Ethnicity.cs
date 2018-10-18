using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Website.Models
{
    [Table("Ethnicities")]
    public class Ethnicity
    {
        [Key, Display(Name ="Ethnicity ID")]
        public Guid EthnicityId { get; set; }

        [Display(Name = "Ethnicity Name")]
        [Required]
        [StringLength(50)]
        public string EthnicityName { get; set; }
    }
}