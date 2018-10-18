using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Website.Models
{
    [Table("ResumeSkills")]
    public class ResumeSkill
    {
        [Key, Column(Order = 0)]
        public Guid ResumeId { get; set; }

        [Key, Column(Order = 1)]
        public Guid SkillCategoryId { get; set; }
    }
}