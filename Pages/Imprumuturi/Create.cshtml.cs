using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProiectMediiAplicatieWeb.Data;
using ProiectMediiAplicatieWeb.Models;

namespace ProiectMediiAplicatieWeb.Pages.Imprumuturi
{
    public class CreateModel : PageModel
    {
        private readonly ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext _context;

        public CreateModel(ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["Nume_Carte"] = new SelectList(_context.Set<Carte>(), "ID", "Nume_Carte");
            ViewData["Nume_Autor"] = new SelectList(_context.Set<Autor>(), "ID", "Nume_Autor");
            ViewData["Nume_Client"] = new SelectList(_context.Set<Client>(), "ID", "Nume_Client");
            ViewData["Prenume_Client"] = new SelectList(_context.Set<Client>(), "ID", "Prenume_Client");
            return Page();
        }

        [BindProperty]
        public Imprumut Imprumut { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Imprumut.Add(Imprumut);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
