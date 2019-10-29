using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GDPRApp.Model
{
    public class AppUser
    {
       
        public string UserEmail {get; set;}
        public string UserPassword {get; set; }
        public string UserPasswordRepeat { get; set; }
        public bool Consent { get; set; }
    }
}
