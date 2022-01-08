using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProiectMediiAplicatieWeb.Models
{
    public class Imprumut
    {
        public int ID { get; set; }

        
        public Carte Carte_Imprumutata { get; set; }
        public Autor Autor { get; set; }

        
        public Client Client { get; set; }

        [DataType(DataType.Date)]

        [Display(Name = "Data Returnarii")]
        
        public DateTime Data_Retur { get; set; }

    }
}
