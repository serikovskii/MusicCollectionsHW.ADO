namespace MusicHW.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Songs", "Singer_Id", "dbo.Singers");
            DropIndex("dbo.Songs", new[] { "Singer_Id" });
            RenameColumn(table: "dbo.Songs", name: "Singer_Id", newName: "SingerId");
            AddColumn("dbo.Descriptions", "SongId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Songs", "SingerId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Songs", "SingerId");
            AddForeignKey("dbo.Songs", "SingerId", "dbo.Singers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "SingerId", "dbo.Singers");
            DropIndex("dbo.Songs", new[] { "SingerId" });
            AlterColumn("dbo.Songs", "SingerId", c => c.Guid());
            DropColumn("dbo.Descriptions", "SongId");
            RenameColumn(table: "dbo.Songs", name: "SingerId", newName: "Singer_Id");
            CreateIndex("dbo.Songs", "Singer_Id");
            AddForeignKey("dbo.Songs", "Singer_Id", "dbo.Singers", "Id");
        }
    }
}
