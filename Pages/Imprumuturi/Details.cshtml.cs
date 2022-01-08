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
    public class DetailsModel : PageModel
    {
        private readonly ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext _context;

        public DetailsModel(ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext context)
        {
            _context = context;
        }

        public Imprumut Imprumut { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Imprumut = await _context.Imprumut
           .Include(b => b.Carte_Imprumutata)
           .Include(b => b.Autor)
           .Include(b => b.Client)
           .AsNoTracking()
           .FirstOrDefaultAsync(m => m.ID == id);

            if (Imprumut == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
