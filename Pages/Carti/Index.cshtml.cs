using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectMediiAplicatieWeb.Data;
using ProiectMediiAplicatieWeb.Models;

namespace ProiectMediiAplicatieWeb.Pages.Carti
{
    public class IndexModel : PageModel
    {
        private readonly ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext _context;

        public IndexModel(ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext context)
        {
            _context = context;
        }

        public IList<Carte> Carte { get;set; }

        public async Task OnGetAsync()
        {
            Carte = await _context.Carte
                .Include(b => b.Autor)
                .ToListAsync();
        }
    }
}
