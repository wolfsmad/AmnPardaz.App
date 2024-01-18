using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmnPardaz.Core.ModelViews
{
    public class LoginModelView
    {
        [Required(ErrorMessage =("{0} is required!"))]
        public string UserName { get; set; }
        [Required(ErrorMessage = ("{0} is required!"))]
        public string Password { get; set; }
    }
}
