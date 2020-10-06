using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using databaseOtters.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace databaseOtters.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly OtterDbContext _db;
        public readonly List<Otter> Otters;

        public IndexModel(ILogger<IndexModel> logger, OtterDbContext db)
        {
            _logger = logger;
            _db = db;
            Otters = db.Otters.ToList();
        }

        public void OnGet()
        {
            
        }
    }
}
