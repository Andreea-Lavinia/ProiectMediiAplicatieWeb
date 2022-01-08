﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext _context;

        public DetailsModel(ProiectMediiAplicatieWeb.Data.ProiectMediiAplicatieWebContext context)
        {
            _context = context;
        }

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
    }
}
