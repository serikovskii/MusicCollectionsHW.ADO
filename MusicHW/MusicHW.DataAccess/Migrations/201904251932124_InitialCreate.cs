namespace MusicHW.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Descriptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Text = c.String(),
                        Duration = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Singers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NameSinger = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NameSong = c.String(),
                        DescriptionSong_Id = c.Guid(),
                        Singer_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Descriptions", t => t.DescriptionSong_Id)
                .ForeignKey("dbo.Singers", t => t.Singer_Id)
                .Index(t => t.DescriptionSong_Id)
                .Index(t => t.Singer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "Singer_Id", "dbo.Singers");
            DropForeignKey("dbo.Songs", "DescriptionSong_Id", "dbo.Descriptions");
            DropIndex("dbo.Songs", new[] { "Singer_Id" });
            DropIndex("dbo.Songs", new[] { "DescriptionSong_Id" });
            DropTable("dbo.Songs");
            DropTable("dbo.Singers");
            DropTable("dbo.Descriptions");
        }
    }
}
