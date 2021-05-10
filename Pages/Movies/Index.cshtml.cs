using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mvc50Indi.Data;
using Mvc50Indi.Models;

namespace Mvc50Indi.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Mvc50Indi.Data.ApplicationDbContext _context;

        public IndexModel(Mvc50Indi.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
