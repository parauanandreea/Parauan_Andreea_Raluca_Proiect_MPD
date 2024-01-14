using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Parauan_Andreea_Raluca_Proiect_MPD.Data;
using Parauan_Andreea_Raluca_Proiect_MPD.Models;

namespace Parauan_Andreea_Raluca_Proiect_MPD.Pages.Proiectul_depus
{
    public class DeleteModel : PageModel
    {
        private readonly Parauan_Andreea_Raluca_Proiect_MPD.Data.Parauan_Andreea_Raluca_Proiect_MPDContext _context;

        public DeleteModel(Parauan_Andreea_Raluca_Proiect_MPD.Data.Parauan_Andreea_Raluca_Proiect_MPDContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Proiect_depus Proiect_depus { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Proiect_depus == null)
            {
                return NotFound();
            }

            var proiect_depus = await _context.Proiect_depus.FirstOrDefaultAsync(m => m.ID == id);

            if (proiect_depus == null)
            {
                return NotFound();
            }
            else 
            {
                Proiect_depus = proiect_depus;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Proiect_depus == null)
            {
                return NotFound();
            }
            var proiect_depus = await _context.Proiect_depus.FindAsync(id);

            if (proiect_depus != null)
            {
                Proiect_depus = proiect_depus;
                _context.Proiect_depus.Remove(Proiect_depus);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
