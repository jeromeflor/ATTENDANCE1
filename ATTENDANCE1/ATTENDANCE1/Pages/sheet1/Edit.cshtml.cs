#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ATTENDANCE1.Data;
using ATTENDANCE1.sheet;

namespace ATTENDANCE1.Pages.sheet1
{
    public class EditModel : PageModel
    {
        private readonly ATTENDANCE1.Data.ATTENDANCE1Context _context;

        public EditModel(ATTENDANCE1.Data.ATTENDANCE1Context context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(sheets).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sheetsExists(sheets.ID))
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

        private bool sheetsExists(int id)
        {
            return _context.sheets.Any(e => e.ID == id);
        }
    }
}
