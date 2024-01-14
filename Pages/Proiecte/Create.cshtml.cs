using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Parauan_Andreea_Raluca_Proiect_MPD.Data;
using Parauan_Andreea_Raluca_Proiect_MPD.Models;

namespace Parauan_Andreea_Raluca_Proiect_MPD.Pages.Proiecte
{
    public class CreateModel : PageModel
    {
        private readonly Parauan_Andreea_Raluca_Proiect_MPD.Data.Parauan_Andreea_Raluca_Proiect_MPDContext _context;

        public CreateModel(Parauan_Andreea_Raluca_Proiect_MPD.Data.Parauan_Andreea_Raluca_Proiect_MPDContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["Fondul_StructuralID"] = new SelectList(_context.Set<Fondul_Structural>(), "ID", "FondulStructural");

            ViewData["Tip_ajutorID"] = new SelectList(_context.Set<Tip_ajutor>(), "ID", "Tipul_ajutor");
            ViewData["Proiect_depusID"] = new SelectList(_context.Set<Proiect_depus>(), "ID", "Proiectul_a_fost_depus");
            return Page();
        }

        [BindProperty]
        public Proiect_MPD Proiect_MPD { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Proiect_MPD == null || Proiect_MPD == null)
            {
                return Page();
            }

            _context.Proiect_MPD.Add(Proiect_MPD);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
