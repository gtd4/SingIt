using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingIt.Models
{
    public class ContactUsViewModel
    {

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        
        [Required(ErrorMessage="Email is required"), EmailAddress(ErrorMessage="Please Enter a Valid Email")]
        public string EmailAddress { get; set; }
        
        [Required(ErrorMessage="You Have Not Entered Anything")]
        public string Message { get; set; }
    }
}
