namespace FileManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFileAndFileType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(nullable: false, maxLength: 255),
                        FileCode = c.String(),
                        Size = c.Int(nullable: false),
                        FileTypeId = c.Byte(nullable: false),
                        DateUploaded = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        FileLocation = c.String(nullable: false),
                        StatusCode = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FileTypes", t => t.FileTypeId, cascadeDelete: true)
                .Index(t => t.FileTypeId);
            
            CreateTable(
                "dbo.FileTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "FileTypeId", "dbo.FileTypes");
            DropIndex("dbo.Files", new[] { "FileTypeId" });
            DropTable("dbo.FileTypes");
            DropTable("dbo.Files");
        }
    }
}
