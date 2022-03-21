#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ATTENDANCE1.Data;
using ATTENDANCE1.sheet;

namespace ATTENDANCE1.Pages.sheet1
{
    public class CreateModel : PageModel
    {
        private readonly ATTENDANCE1.Data.ATTENDANCE1Context _context;

        public CreateModel(ATTENDANCE1.Data.ATTENDANCE1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public sheets sheets { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.sheets.Add(sheets);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
