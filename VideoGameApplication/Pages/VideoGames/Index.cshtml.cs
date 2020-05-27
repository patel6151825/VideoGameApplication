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
    public class IndexModel : PageModel
    {
        private readonly VideoGameApplication.Models.VideoGameApplicationContext _context;

        public IndexModel(VideoGameApplication.Models.VideoGameApplicationContext context)
        {
            _context = context;
        }

        public IList<VideoGame> VideoGame { get;set; }

        public async Task OnGetAsync()
        {
            VideoGame = await _context.VideoGame.ToListAsync();
        }
    }
}
