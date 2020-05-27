using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VideoGameApplication.Models;

namespace VideoGameApplication.Pages.VideoGames
{
    public class DetailsModel : PageModel
    {
        private readonly VideoGameApplication.Models.VideoGameApplicationContext _context;

        public DetailsModel(VideoGameApplication.Models.VideoGameApplicationContext context)
        {
            _context = context;
        }

        public VideoGame VideoGame { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VideoGame = await _context.VideoGame.FirstOrDefaultAsync(m => m.Id == id);

            if (VideoGame == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
