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

        public AddJobViewModel()
        {

        }
        public AddJobViewModel(List<Employer> _employers)
        {

        }
    }
}
