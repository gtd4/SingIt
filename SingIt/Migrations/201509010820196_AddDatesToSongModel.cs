namespace SingIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatesToSongModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Songs", "DateModified", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Songs", "DateModified");
            DropColumn("dbo.Songs", "DateCreated");
        }
    }
}
