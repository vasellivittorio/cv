using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Models
{
    public class ProjectSkill
    {
        public int SkillId { get; set; }
        public int ProjectId { get; set; }
        public string HowSkillIsUsed { get; set; }
    }
}