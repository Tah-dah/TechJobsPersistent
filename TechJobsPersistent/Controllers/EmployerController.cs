using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {

        private JobDbContext context;

        public EmployerController(JobDbContext _dbContext)
        {
            context = _dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();
            return View(employers);
            
        }

        public IActionResult Add()
        {
            AddEmployerViewModel employer = new AddEmployerViewModel();
            return View(employer);
        }

        public IActionResult ProcessAddEmployerForm(AddJobSkillViewModel _employer)
        {
            if (!ModelState.IsValid)
            {
                Employer newEmployer = new Employer
                {
                    Name = _employer.Name,
                    Location = _employer.Location
                };
                context.Employers.Add(newEmployer);
                
                return Redirect("/Employer"); 
            }
            return View(_employer);
        }

        public IActionResult About(int id)
        {
            Employer employer = context.Employers.Find(id);
            return View(employer);
        }
    }
}
