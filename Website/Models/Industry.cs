using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Website.Models
{
    [Table("Industries")]
    public class Industry
    {
        [Key, Display(Name = "Industry ID")]
        public Guid IndustryId { get; set; }
        [Display(Name = "Industry Name")]
        public string IndustryName { get; set; }
    }
}