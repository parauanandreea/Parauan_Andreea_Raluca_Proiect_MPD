﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Parauan_Andreea_Raluca_Proiect_MPD.Data;
using Parauan_Andreea_Raluca_Proiect_MPD.Models;

namespace Parauan_Andreea_Raluca_Proiect_MPD.Pages.Proiecte
{
    public class DetailsModel : PageModel
    {
        private readonly Parauan_Andreea_Raluca_Proiect_MPD.Data.Parauan_Andreea_Raluca_Proiect_MPDContext _context;

        public DetailsModel(Parauan_Andreea_Raluca_Proiect_MPD.Data.Parauan_Andreea_Raluca_Proiect_MPDContext context)
        {
            _context = context;
        }

      public Proiect_MPD Proiect_MPD { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Proiect_MPD == null)
            {
                return NotFound();
            }

            var proiect_mpd = await _context.Proiect_MPD.FirstOrDefaultAsync(m => m.ID == id);
            if (proiect_mpd == null)
            {
                return NotFound();
            }
            else 
            {
                Proiect_MPD = proiect_mpd;
            }
            return Page();


            ViewData["Fondul_StructuralID"] = new SelectList(_context.Set<Fondul_Structural>(), "ID", "FondulStructural");

            ViewData["Tip_ajutorID"] = new SelectList(_context.Set<Tip_ajutor>(), "ID", "Tipul_ajutor");
            return Page();
        }
    }
}
