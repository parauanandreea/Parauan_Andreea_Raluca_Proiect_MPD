using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Parauan_Andreea_Raluca_Proiect_MPD.Data;
using Parauan_Andreea_Raluca_Proiect_MPD.Models;

namespace Parauan_Andreea_Raluca_Proiect_MPD.Pages.Proiecte
{
    public class IndexModel : PageModel
    {
        private readonly Parauan_Andreea_Raluca_Proiect_MPD.Data.Parauan_Andreea_Raluca_Proiect_MPDContext _context;

        public IndexModel(Parauan_Andreea_Raluca_Proiect_MPD.Data.Parauan_Andreea_Raluca_Proiect_MPDContext context)
        {
            _context = context;
        }

        public IList<Proiect_MPD> Proiect_MPD { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Proiect_MPD != null)
            {
                Proiect_MPD = await _context.Proiect_MPD
                    .Include(b=>b.Fondul_Structural)
                    .Include(b=>b.Tip_ajutor)
                    .Include(b=>b.Proiect_depus)
                    .ToListAsync(); 
                
            ; }
        }
    }
}
