#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ATTENDANCE1.Data;
using ATTENDANCE1.sheet;

namespace ATTENDANCE1.Pages.sheet1
{
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8602
#pragma warning disable CS8604
    public class DeleteModel : PageModel
    {
        private readonly ATTENDANCE1.Data.ATTENDANCE1Context _context;

        public DeleteModel(ATTENDANCE1.Data.ATTENDANCE1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public sheets sheets { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            sheets = await _context.sheets.FirstOrDefaultAsync(m => m.ID == id);

            if (sheets == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            sheets = await _context.sheets.FindAsync(id);

            if (sheets != null)
            {
                _context.sheets.Remove(sheets);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8602
#pragma warning restore CS8604
}
