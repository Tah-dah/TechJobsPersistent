using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string EmployerId { get; set;}
        public string Name { get; set;}
        public List<SelectListItem> Employers { get; set; }
        public List<Skill>Skills { get; set; }

        public AddJobViewModel()
        {

        }
        public AddJobViewModel(List<Employer> _employers, List<Skill> skills)
        {
            this.Skills = skills;
            this.Employers = new List<SelectListItem>();
            
            foreach (Employer employer in _employers)
            {
                this.Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
                
               

            
        }
    }
}
