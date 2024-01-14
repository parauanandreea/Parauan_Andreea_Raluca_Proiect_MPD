using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Parauan_Andreea_Raluca_Proiect_MPD.Data;
using Parauan_Andreea_Raluca_Proiect_MPD.Models;

namespace Parauan_Andreea_Raluca_Proiect_MPD.Pages.Fond_Structural
{
    public class DetailsModel : PageModel
    {
        private readonly Parauan_Andreea_Raluca_Proiect_MPD.Data.Parauan_Andreea_Raluca_Proiect_MPDContext _context;

        public DetailsModel(Parauan_Andreea_Raluca_Proiect_MPD.Data.Parauan_Andreea_Raluca_Proiect_MPDContext context)
        {
            _context = context;
        }

      public Fondul_Structural Fondul_Structural { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Fondul_Structural == null)
            {
                return NotFound();
            }

            var fondul_structural = await _context.Fondul_Structural.FirstOrDefaultAsync(m => m.ID == id);
            if (fondul_structural == null)
            {
                return NotFound();
            }
            else 
            {
                Fondul_Structural = fondul_structural;
            }
            return Page();
        }
    }
}
