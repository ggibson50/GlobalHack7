using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Website.Models
{
    [Table("Resume")]
    public class Resume
    {
        [Key, Display(Name = "#")]
        public Guid ResumeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name Required")]
        [StringLength(40)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Required")]
        [StringLength(40)]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [MinLength(10)]
        public string PhoneNumber { get; set; }

        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(70)]
        public string Email { get; set; }

        [Display(Name ="Language Code")]
        //[Required(ErrorMessage = "Language Required")]
        [StringLength(5)]
        public string LanguageCode { get; set; }

        [Display(Name = "Orignal Resume")]
        public Guid? OriginalResumeId { get; set; }

        // Navigation

        [ForeignKey("OriginalResumeId")]
        public virtual Resume OriginalResume { get; set; }
        [ForeignKey("LanguageCode")]
        public virtual Language Language { get; set; }

        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
    }
}
