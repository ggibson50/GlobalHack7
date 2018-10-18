using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Website.Models
{
    [Table("JobSkill")]
    public class JobSkill
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

        //[ForeignKey("SkillType")]
        //public virtual SkillType SkillTypeObject { get; set; }

        //[ForeignKey("SkillCategory")]
        //public virtual SkillCategory SkillCategoryObject { get; set; }
    }
}