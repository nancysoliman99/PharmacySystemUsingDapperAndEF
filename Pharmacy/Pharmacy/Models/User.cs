using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
        [NotMapped]
        public string conf_Password { get; set; }
        public string Email { get; set; }
        
    }
}
