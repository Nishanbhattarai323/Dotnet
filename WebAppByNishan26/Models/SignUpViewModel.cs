using System.ComponentModel.DataAnnotations;

namespace WebAppByNishan26.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage ="Name is required")]
            public string Name { get; set; }
        [Required(ErrorMessage ="RollNo is Required")]
        public string RollNo {  get; set; }
    }
}
