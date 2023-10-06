using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayoutIntroandForm.Models
{
    public class Signup
    {
        [Required(ErrorMessage ="Please provide your name")]
        [StringLength(5,ErrorMessage ="Length must be <5")]
        public string Name { get; set; }
        
        //public int Id { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]

        public String[] Interest {  get; set; }
        [Required]
        public string Profession { get; set; }

    }
}
