using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Website.ViewModels
{
    public class JobSkillInfo
    {
        [Display(Name = "Job Skill Id"), Key]
        public Guid JobSkillId { get; set; }
        [Display(Name = "Job Skill Name")]
        public string JobSkillName { get; set; }
        [Display(Name = "Skill Type")]
        public string SkillType { get; set; }
        [Display(Name = "Skill Category")]
        public string SkillCategory { get; set; }
        [Display(Name = "Skill Image")]
        public string Image { get; set; }

        public bool Checked { get; set; }
    }
}