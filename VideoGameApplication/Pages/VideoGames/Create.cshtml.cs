﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VideoGameApplication.Models;

namespace VideoGameApplication.Pages.VideoGames
{
    public class CreateModel : PageModel
    {
        private readonly VideoGameApplication.Models.VideoGameApplicationContext _context;

        public CreateModel(VideoGameApplication.Models.VideoGameApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VideoGame VideoGame { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.VideoGame.Add(VideoGame);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
