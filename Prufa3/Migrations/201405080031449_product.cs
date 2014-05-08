namespace Prufa3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        sUsername = c.String(nullable: false, maxLength: 128),
                        sPass = c.String(nullable: false),
                        sEmail = c.String(nullable: false),
                        iRanking = c.Int(nullable: false),
                        dSignupDate = c.DateTime(nullable: false),
                        iTheme = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.sUsername);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        iCommentId = c.Int(nullable: false, identity: true),
                        sCommenterUsername = c.String(nullable: false),
                        sCommentText = c.String(nullable: false),
                        dCommentDate = c.DateTime(nullable: false),
                        Client_sUsername = c.String(maxLength: 128),
                        Request_iRequestId = c.Int(),
                        SubFile_iSubFileId = c.Int(),
                    })
                .PrimaryKey(t => t.iCommentId)
                .ForeignKey("dbo.Client", t => t.Client_sUsername)
                .ForeignKey("dbo.Request", t => t.Request_iRequestId)
                .ForeignKey("dbo.SubFile", t => t.SubFile_iSubFileId)
                .Index(t => t.Client_sUsername)
                .Index(t => t.Request_iRequestId)
                .Index(t => t.SubFile_iSubFileId);
            
            CreateTable(
                "dbo.Request",
                c => new
                    {
                        iRequestId = c.Int(nullable: false, identity: true),
                        sRequesterUsername = c.String(nullable: false),
                        sTitle = c.String(nullable: false),
                        sLanguageTo = c.String(),
                        sLanguageFrom = c.String(),
                        sSubType = c.String(),
                        iUpVote = c.Int(nullable: false),
                        dRequestDate = c.DateTime(nullable: false),
                        sPicture = c.String(),
                        sRequestDescription = c.String(),
                        iSubFileId = c.Int(nullable: false),
                        sUsername = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.iRequestId)
                .ForeignKey("dbo.Client", t => t.sUsername)
                .Index(t => t.sUsername);
            
            CreateTable(
                "dbo.SubFile",
                c => new
                    {
                        iSubFileId = c.Int(nullable: false, identity: true),
                        sTitle = c.String(nullable: false),
                        sSubLanguage = c.String(),
                        sSubType = c.String(),
                        sGenre = c.String(),
                        dSubDate = c.DateTime(nullable: false),
                        sPicture = c.String(),
                        sSubDescription = c.String(),
                        sFilePath = c.String(),
                        iUpVote = c.Int(nullable: false),
                        sUsername = c.String(maxLength: 128),
                        iRequestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.iSubFileId)
                .ForeignKey("dbo.Client", t => t.sUsername)
                .Index(t => t.sUsername);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubFile", "sUsername", "dbo.Client");
            DropForeignKey("dbo.Comment", "SubFile_iSubFileId", "dbo.SubFile");
            DropForeignKey("dbo.Request", "sUsername", "dbo.Client");
            DropForeignKey("dbo.Comment", "Request_iRequestId", "dbo.Request");
            DropForeignKey("dbo.Comment", "Client_sUsername", "dbo.Client");
            DropIndex("dbo.SubFile", new[] { "sUsername" });
            DropIndex("dbo.Request", new[] { "sUsername" });
            DropIndex("dbo.Comment", new[] { "SubFile_iSubFileId" });
            DropIndex("dbo.Comment", new[] { "Request_iRequestId" });
            DropIndex("dbo.Comment", new[] { "Client_sUsername" });
            DropTable("dbo.SubFile");
            DropTable("dbo.Request");
            DropTable("dbo.Comment");
            DropTable("dbo.Client");
        }
    }
}
