using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayoutIntroandForm.Models
{
    public class Signup
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Gender { get; set; }
        public List<string> Interest {  get; set; }
        public string Profession { get; set; }
    }
}
