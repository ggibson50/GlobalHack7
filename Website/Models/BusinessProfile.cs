 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Website.Models
{
    [Table("BusinessProfiles")]
    public class BusinessProfile
    {
        [Key, Display(Name = "Business#")]
        public int BusinessId { get; set; }
        [Required]
        [Display(Name = "BusinessName")]
        public string BusinessName { get; set; }
        [StringLength(100)]
        [Display(Name = "ShortDescription")]
        [DataType(DataType.MultilineText)]
        public string ShortBusinessDescription { get; set; }
        [StringLength(250)]
        [Display(Name = "LongDescription")]
        [DataType(DataType.MultilineText)]
        public string LongBusinessDescription { get; set; }
        [StringLength(2)]
        [Display(Name = "State")]
        public string State { get; set; }
        [StringLength(40)]
        [Display(Name = "City")]
        public string City { get; set; }
        [StringLength(40)]
        [Display(Name = "StreetAddress")]
        public string StreetAddress { get; set; }
        [StringLength(50)]
        [Display(Name = "EmailAddress")]
        public string EmailAddress { get; set; }
        [StringLength(10)]
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [StringLength(40)]
        [Display(Name = "Image")]
        public string Image { get; set; }

        //[Required]
        [Display(Name = "Industry")]
        public Guid? IndustryId { get; set; }
        public virtual Industry Industry { get; set; }

    }
}