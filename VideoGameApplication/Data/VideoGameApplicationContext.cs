using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VideoGameApplication.Models
{
    public class VideoGameApplicationContext : DbContext
    {
        public VideoGameApplicationContext (DbContextOptions<VideoGameApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<VideoGameApplication.Models.VideoGame> VideoGame { get; set; }
    }
}
