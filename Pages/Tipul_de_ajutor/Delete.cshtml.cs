using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Parauan_Andreea_Raluca_Proiect_MPD.Data;
using Parauan_Andreea_Raluca_Proiect_MPD.Models;

namespace Parauan_Andreea_Raluca_Proiect_MPD.Pages.Tipul_de_ajutor
{
    public class DeleteModel : PageModel
    {
        private readonly Parauan_Andreea_Raluca_Proiect_MPD.Data.Parauan_Andreea_Raluca_Proiect_MPDContext _context;

        public DeleteModel(Parauan_Andreea_Raluca_Proiect_MPD.Data.Parauan_Andreea_Raluca_Proiect_MPDContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Tip_ajutor Tip_ajutor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tip_ajutor == null)
            {
                return NotFound();
            }

            var tip_ajutor = await _context.Tip_ajutor.FirstOrDefaultAsync(m => m.ID == id);

            if (tip_ajutor == null)
            {
                return NotFound();
            }
            else 
            {
                Tip_ajutor = tip_ajutor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Tip_ajutor == null)
            {
                return NotFound();
            }
            var tip_ajutor = await _context.Tip_ajutor.FindAsync(id);

            if (tip_ajutor != null)
            {
                Tip_ajutor = tip_ajutor;
                _context.Tip_ajutor.Remove(Tip_ajutor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
