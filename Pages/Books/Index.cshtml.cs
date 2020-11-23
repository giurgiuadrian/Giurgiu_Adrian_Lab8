using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Giurgiu_Adrian_Lab8.Data;
using Giurgiu_Adrian_Lab8.Models;

namespace Giurgiu_Adrian_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Giurgiu_Adrian_Lab8.Data.Giurgiu_Adrian_Lab8Context _context;

        public IndexModel(Giurgiu_Adrian_Lab8.Data.Giurgiu_Adrian_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
            .Include(b => b.Publisher)
            .ToListAsync();
        }
    }
}
