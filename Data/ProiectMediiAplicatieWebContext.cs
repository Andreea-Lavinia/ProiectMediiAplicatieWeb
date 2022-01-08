using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectMediiAplicatieWeb.Models;

namespace ProiectMediiAplicatieWeb.Data
{
    public class ProiectMediiAplicatieWebContext : DbContext
    {
        public ProiectMediiAplicatieWebContext (DbContextOptions<ProiectMediiAplicatieWebContext> options)
            : base(options)
        {
        }

        public DbSet<ProiectMediiAplicatieWeb.Models.Carte> Carte { get; set; }

        public DbSet<ProiectMediiAplicatieWeb.Models.Autor> Autor { get; set; }

        public DbSet<ProiectMediiAplicatieWeb.Models.Bibliotecar> Bibliotecar { get; set; }

        public DbSet<ProiectMediiAplicatieWeb.Models.Client> Client { get; set; }

        public DbSet<ProiectMediiAplicatieWeb.Models.Imprumut> Imprumut { get; set; }
    }
}
