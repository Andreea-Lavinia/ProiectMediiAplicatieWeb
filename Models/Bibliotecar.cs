using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProiectMediiAplicatieWeb.Models
{
    public class Bibliotecar
    {
        [Key]
        public int CNP  { get; set; }


        [Display(Name = "Numele Bibliotecarului")]
        public string Nume_Bibliotecar { get; set; }

        

        [Display(Name = "Prenumele Bibliotecarului")]

        public string Prenume_Bibliotecar { get; set; }

        [Display(Name = "Numar Telefon")]
        public string numar_telefon { get; set; }

         public Carte Carte_Imprumutata { get; set; }
    }


    }

