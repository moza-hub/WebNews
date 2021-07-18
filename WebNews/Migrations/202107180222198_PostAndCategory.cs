namespace WebNews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostAndCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CateId = c.Int(nullable: false, identity: true),
                        CateName = c.String(),
                    })
                .PrimaryKey(t => t.CateId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        PostTitle = c.String(),
                        PostContent = c.String(),
                        PostImg = c.String(),
                        PostUrl = c.String(),
                        CateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Categories", t => t.CateId, cascadeDelete: true)
                .Index(t => t.CateId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "CateId", "dbo.Categories");
            DropIndex("dbo.Posts", new[] { "CateId" });
            DropTable("dbo.Posts");
            DropTable("dbo.Categories");
        }
    }
}
