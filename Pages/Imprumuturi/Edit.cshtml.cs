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

namespace ProiectMediiAplicatieWeb.Pages.Imprumuturi
{
    public class EditModel : PageModel
    {
        private readonly ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext _context;

        public EditModel(ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext context)
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
            ViewData["Nume_Carte"] = new SelectList(_context.Set<Carte>(), "ID", "Nume_Carte");
            ViewData["Nume_Autor"] = new SelectList(_context.Set<Autor>(), "ID", "Nume_Autor");
            ViewData["Nume_Client"] = new SelectList(_context.Set<Client>(), "ID", "Nume_Client");
            ViewData["Prenume_Client"] = new SelectList(_context.Set<Client>(), "ID", "Prenume_Client");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Imprumut).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImprumutExists(Imprumut.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ImprumutExists(int id)
        {
            return _context.Imprumut.Any(e => e.ID == id);
        }
    }
}
