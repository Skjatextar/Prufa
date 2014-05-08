namespace Prufa3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comment", "dCommentDate", c => c.DateTime());
            AlterColumn("dbo.Request", "iUpVote", c => c.Int());
            AlterColumn("dbo.Request", "dRequestDate", c => c.DateTime());
            AlterColumn("dbo.SubFile", "dSubDate", c => c.DateTime());
            AlterColumn("dbo.SubFile", "iUpVote", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SubFile", "iUpVote", c => c.Int(nullable: false));
            AlterColumn("dbo.SubFile", "dSubDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Request", "dRequestDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Request", "iUpVote", c => c.Int(nullable: false));
            AlterColumn("dbo.Comment", "dCommentDate", c => c.DateTime(nullable: false));
        }
    }
}
