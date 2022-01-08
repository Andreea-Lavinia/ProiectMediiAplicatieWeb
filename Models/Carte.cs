using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProiectMediiAplicatieWeb.Models
{
    public class Carte
    {
        public int ID { get; set; }


        [Display(Name = "Denumirea Cartii")]
        public string Nume_Carte { get; set; }

        
        public decimal Pagini { get; set; }

        
        public string Categorie { get; set; }

        
        public Autor Autor { get; set; }
        
        public ICollection<Bibliotecar> Bibliotecar { get; set; }
        public ICollection<Client> Client { get; set; }

        public ICollection<Imprumut> Imprumut { get; set; }

    }
}
