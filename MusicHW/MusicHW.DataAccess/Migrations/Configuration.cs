namespace MusicHW.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    internal sealed class Configuration : DbMigrationsConfiguration<MusicHW.DataAccess.MusicContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MusicHW.DataAccess.MusicContext";
        }

        protected override void Seed(MusicHW.DataAccess.MusicContext context)
        {
            
        }
    }
}
