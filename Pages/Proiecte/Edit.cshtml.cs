using System;
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
    public class EditModel : PageModel
    {
        private readonly Parauan_Andreea_Raluca_Proiect_MPD.Data.Parauan_Andreea_Raluca_Proiect_MPDContext _context;

        public EditModel(Parauan_Andreea_Raluca_Proiect_MPD.Data.Parauan_Andreea_Raluca_Proiect_MPDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Proiect_MPD Proiect_MPD { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Proiect_MPD == null)
            {
                return NotFound();
            }

            var proiect_mpd =  await _context.Proiect_MPD.FirstOrDefaultAsync(m => m.ID == id);
            if (proiect_mpd == null)
            {
                return NotFound();
            }
            Proiect_MPD = proiect_mpd;
            ViewData["Fondul_StructuralID"] = new SelectList(_context.Set<Fondul_Structural>(), "ID", "FondulStructural");

            ViewData["Tip_ajutorID"] = new SelectList(_context.Set<Tip_ajutor>(), "ID", "Tipul_ajutor");
            ViewData["Proiect_depusID"] = new SelectList(_context.Set<Proiect_depus>(), "ID", "Proiectul_a_fost_depus");
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

            _context.Attach(Proiect_MPD).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Proiect_MPDExists(Proiect_MPD.ID))
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

        private bool Proiect_MPDExists(int id)
        {
          return (_context.Proiect_MPD?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
