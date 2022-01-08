using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProiectMediiAplicatieWeb.Data;
using ProiectMediiAplicatieWeb.Models;

namespace ProiectMediiAplicatieWeb.Pages.Bibliotecari
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
            return Page();
        }

        [BindProperty]
        public Bibliotecar Bibliotecar { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bibliotecar.Add(Bibliotecar);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
