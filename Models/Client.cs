using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProiectMediiAplicatieWeb.Models
{
    public class Client
    {
        [Key]
        public int CNP { get; set; }

        

        [Display(Name = "Numele Clientului")]
        public string Nume_Client { get; set; }

        

        [Display(Name = "Prenumele Clientului")]
        public string Prenume_Client { get; set; }

        [Display(Name = "Numar Telefon")]
        public string numar_telefon { get; set; }

        [Display(Name = "Titlul Cartii Luate Imprumut")]
        public Carte Carte_Luata_Imprumut { get; set; }

        public ICollection<Imprumut> Imprumut { get; set; }
    }
}

