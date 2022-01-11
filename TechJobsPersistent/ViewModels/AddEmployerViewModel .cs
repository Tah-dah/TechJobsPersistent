using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
       
        public string Name { get; set; }
        [Required(ErrorMessage = "An employer can only have one location.")]
        public string Location { get; set; }
    }
}
