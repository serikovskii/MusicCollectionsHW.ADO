namespace MusicHW.DataAccess
{
    using MusicHW.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MusicContext : DbContext
    {
        public MusicContext()
            : base("name=MusicContext")
        {
        }

        public virtual DbSet<Singer> Singers { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<Description> Descriptions { get; set; }
    }
}