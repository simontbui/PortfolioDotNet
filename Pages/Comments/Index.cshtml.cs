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
    public class IndexModel : PageModel
    {
        private readonly PortfolioDotNet.Data.PortfolioDotNetContext _context;

        public IndexModel(PortfolioDotNet.Data.PortfolioDotNetContext context)
        {
            _context = context;
        }

        public IList<Comment> Comment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Comment != null)
            {
                Comment = await _context.Comment.ToListAsync();
            }
        }
    }
}
