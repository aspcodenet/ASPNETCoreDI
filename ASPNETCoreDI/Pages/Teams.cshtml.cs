using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreDI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreDI.Pages
{
    public class TeamsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<TeamViewModel> Teams { get; set; }

        public class TeamViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public TeamsModel(ApplicationDbContext context )
        {
            _context = context;
        }



        public void OnGet()
        {
            Teams = _context.Teams.Select(r => new TeamViewModel
            {
                Id = r.Id,
                Name = r.Namn
            }).ToList();
        }
    }
}
