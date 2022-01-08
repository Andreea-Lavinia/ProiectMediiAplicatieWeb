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
    public class DeleteModel : PageModel
    {
        private readonly ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext _context;

        public DeleteModel(ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Carte Carte { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Carte = await _context.Carte
            .Include(b => b.Autor)
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.ID == id);

            if (Carte == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Carte = await _context.Carte.FindAsync(id);

            if (Carte != null)
            {
                _context.Carte.Remove(Carte);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
