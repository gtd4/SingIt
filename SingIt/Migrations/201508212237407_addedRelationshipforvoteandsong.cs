namespace SingIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedRelationshipforvoteandsong : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        VoteId = c.Int(nullable: false, identity: true),
                        song_SongId = c.Int(),
                        voter_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.VoteId)
                .ForeignKey("dbo.Songs", t => t.song_SongId)
                .ForeignKey("dbo.AspNetUsers", t => t.voter_Id)
                .Index(t => t.song_SongId)
                .Index(t => t.voter_Id);
            
            DropColumn("dbo.Songs", "VoteCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "VoteCount", c => c.String());
            DropForeignKey("dbo.Votes", "voter_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Votes", "song_SongId", "dbo.Songs");
            DropIndex("dbo.Votes", new[] { "voter_Id" });
            DropIndex("dbo.Votes", new[] { "song_SongId" });
            DropTable("dbo.Votes");
        }
    }
}
