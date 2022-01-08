using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectMediiAplicatieWeb.Data;
using ProiectMediiAplicatieWeb.Models;

namespace ProiectMediiAplicatieWeb.Pages.Imprumuturi
{
    public class IndexModel : PageModel
    {
        private readonly ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext _context;

        public IndexModel(ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext context)
        {
            _context = context;
        }

        public IList<Imprumut> Imprumut { get;set; }

        public async Task OnGetAsync()
        {
            Imprumut = await _context.Imprumut
                .Include(b => b.Carte_Imprumutata)
                .Include(b => b.Autor)
                .Include(b => b.Client)
                .ToListAsync();
        }
    }
}
