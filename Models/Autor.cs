using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProiectMediiAplicatieWeb.Models
{
    public class Autor
    {
        
        public int ID { get; set; }
        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$", ErrorMessage = "Numele autorului trebuie sa fie de forma 'Nume Prenume'")]
        [Display(Name = "Nume si Prenume Autor")]
        public string Nume_Autor { get; set; }
        public ICollection<Carte> Books { get; set; }

        public ICollection<Imprumut> Imprumut { get; set; }
    }
}
