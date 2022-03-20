using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Required, Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}."), Display(Name = "Twój szczęśliwy numerek")]
        public int Number { get; set; }

    }
}
