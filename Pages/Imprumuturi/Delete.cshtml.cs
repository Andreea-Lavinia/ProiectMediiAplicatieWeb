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
    public class DeleteModel : PageModel
    {
        private readonly ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext _context;

        public DeleteModel(ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Imprumut Imprumut { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Imprumut = await _context.Imprumut.FirstOrDefaultAsync(m => m.ID == id);

            if (Imprumut == null)
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

            Imprumut = await _context.Imprumut.FindAsync(id);

            if (Imprumut != null)
            {
                _context.Imprumut.Remove(Imprumut);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
