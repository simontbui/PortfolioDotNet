using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PortfolioDotNet.Data;
using PortfolioDotNet.Models;

namespace PortfolioDotNet.Pages.Comments
{
    public class DetailsModel : PageModel
    {
        private readonly PortfolioDotNet.Data.PortfolioDotNetContext _context;

        public DetailsModel(PortfolioDotNet.Data.PortfolioDotNetContext context)
        {
            _context = context;
        }

      public Comment Comment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Comment == null)
            {
                return NotFound();
            }

            var comment = await _context.Comment.FirstOrDefaultAsync(m => m.ID == id);
            if (comment == null)
            {
                return NotFound();
            }
            else 
            {
                Comment = comment;
            }
            return Page();
        }
    }
}
