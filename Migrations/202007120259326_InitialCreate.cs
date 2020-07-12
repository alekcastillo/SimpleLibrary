namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Ttitle = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BookPublishers",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Ttitle = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        Type_Id = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BookTypes", t => t.Type_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Type_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.BookTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Title = c.String(maxLength: 4000),
                        Year = c.Int(nullable: false),
                        Pages = c.Int(nullable: false),
                        Author_Id = c.Guid(),
                        Publisher_Id = c.Guid(),
                        Subject_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BookAuthors", t => t.Author_Id)
                .ForeignKey("dbo.BookPublishers", t => t.Publisher_Id)
                .ForeignKey("dbo.BookSubjects", t => t.Subject_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.Publisher_Id)
                .Index(t => t.Subject_Id);
            
            CreateTable(
                "dbo.BookSubjects",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Ttitle = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Infractions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Book_Id = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Email = c.String(maxLength: 4000),
                        Password = c.String(maxLength: 4000),
                        FirstName = c.String(maxLength: 4000),
                        LastName = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Infractions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Books", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Infractions", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Books", "Type_Id", "dbo.BookTypes");
            DropForeignKey("dbo.BookTypes", "Subject_Id", "dbo.BookSubjects");
            DropForeignKey("dbo.BookTypes", "Publisher_Id", "dbo.BookPublishers");
            DropForeignKey("dbo.BookTypes", "Author_Id", "dbo.BookAuthors");
            DropIndex("dbo.Infractions", new[] { "User_Id" });
            DropIndex("dbo.Infractions", new[] { "Book_Id" });
            DropIndex("dbo.BookTypes", new[] { "Subject_Id" });
            DropIndex("dbo.BookTypes", new[] { "Publisher_Id" });
            DropIndex("dbo.BookTypes", new[] { "Author_Id" });
            DropIndex("dbo.Books", new[] { "User_Id" });
            DropIndex("dbo.Books", new[] { "Type_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Infractions");
            DropTable("dbo.BookSubjects");
            DropTable("dbo.BookTypes");
            DropTable("dbo.Books");
            DropTable("dbo.BookPublishers");
            DropTable("dbo.BookAuthors");
        }
    }
}
