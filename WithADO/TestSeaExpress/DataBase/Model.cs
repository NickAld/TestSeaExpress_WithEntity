using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;

using System.Threading.Tasks;

namespace DataBase
{
    public class Person
    {

        public int UserID { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string LastName { get; set; }


        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }


        [Display(Name = "E-mail")]
        public string Email { get; set; }

    }
}
