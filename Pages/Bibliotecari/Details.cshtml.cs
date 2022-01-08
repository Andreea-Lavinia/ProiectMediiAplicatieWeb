using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProiectMediiAplicatieWeb.Data;
using ProiectMediiAplicatieWeb.Models;

namespace ProiectMediiAplicatieWeb.Pages.Bibliotecari
{
    public class DetailsModel : PageModel
    {
        private readonly ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext _context;

        public DetailsModel(ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext context)
        {
            _context = context;
        }

        public Bibliotecar Bibliotecar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bibliotecar = await _context.Bibliotecar
            .Include(b => b.Carte_Imprumutata)
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.CNP == id);

            if (Bibliotecar == null)
            {
                return NotFound();
            }
            ViewData["Nume_Carte"] = new SelectList(_context.Set<Carte>(), "ID", "Nume_Carte");
            return Page();
        }
    }
}
