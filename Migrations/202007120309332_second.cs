namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookTypes", "Author_Id", "dbo.BookAuthors");
            DropForeignKey("dbo.BookTypes", "Publisher_Id", "dbo.BookPublishers");
            DropForeignKey("dbo.Infractions", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.BookTypes", "Subject_Id", "dbo.BookSubjects");
            DropForeignKey("dbo.Books", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Infractions", "User_Id", "dbo.Users");
            DropIndex("dbo.Books", new[] { "User_Id" });
            DropIndex("dbo.BookTypes", new[] { "Author_Id" });
            DropIndex("dbo.BookTypes", new[] { "Publisher_Id" });
            DropIndex("dbo.BookTypes", new[] { "Subject_Id" });
            DropIndex("dbo.Infractions", new[] { "Book_Id" });
            DropIndex("dbo.Infractions", new[] { "User_Id" });
            DropPrimaryKey("dbo.BookAuthors");
            DropPrimaryKey("dbo.BookPublishers");
            DropPrimaryKey("dbo.Books");
            DropPrimaryKey("dbo.BookSubjects");
            DropPrimaryKey("dbo.Infractions");
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.BookAuthors", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.BookPublishers", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Books", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Books", "User_Id", c => c.Int());
            AlterColumn("dbo.BookTypes", "Author_Id", c => c.Int());
            AlterColumn("dbo.BookTypes", "Publisher_Id", c => c.Int());
            AlterColumn("dbo.BookTypes", "Subject_Id", c => c.Int());
            AlterColumn("dbo.BookSubjects", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Infractions", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Infractions", "Book_Id", c => c.Int());
            AlterColumn("dbo.Infractions", "User_Id", c => c.Int());
            AlterColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.BookAuthors", "Id");
            AddPrimaryKey("dbo.BookPublishers", "Id");
            AddPrimaryKey("dbo.Books", "Id");
            AddPrimaryKey("dbo.BookSubjects", "Id");
            AddPrimaryKey("dbo.Infractions", "Id");
            AddPrimaryKey("dbo.Users", "Id");
            CreateIndex("dbo.Books", "User_Id");
            CreateIndex("dbo.BookTypes", "Author_Id");
            CreateIndex("dbo.BookTypes", "Publisher_Id");
            CreateIndex("dbo.BookTypes", "Subject_Id");
            CreateIndex("dbo.Infractions", "Book_Id");
            CreateIndex("dbo.Infractions", "User_Id");
            AddForeignKey("dbo.BookTypes", "Author_Id", "dbo.BookAuthors", "Id");
            AddForeignKey("dbo.BookTypes", "Publisher_Id", "dbo.BookPublishers", "Id");
            AddForeignKey("dbo.Infractions", "Book_Id", "dbo.Books", "Id");
            AddForeignKey("dbo.BookTypes", "Subject_Id", "dbo.BookSubjects", "Id");
            AddForeignKey("dbo.Books", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Infractions", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Infractions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Books", "User_Id", "dbo.Users");
            DropForeignKey("dbo.BookTypes", "Subject_Id", "dbo.BookSubjects");
            DropForeignKey("dbo.Infractions", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.BookTypes", "Publisher_Id", "dbo.BookPublishers");
            DropForeignKey("dbo.BookTypes", "Author_Id", "dbo.BookAuthors");
            DropIndex("dbo.Infractions", new[] { "User_Id" });
            DropIndex("dbo.Infractions", new[] { "Book_Id" });
            DropIndex("dbo.BookTypes", new[] { "Subject_Id" });
            DropIndex("dbo.BookTypes", new[] { "Publisher_Id" });
            DropIndex("dbo.BookTypes", new[] { "Author_Id" });
            DropIndex("dbo.Books", new[] { "User_Id" });
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.Infractions");
            DropPrimaryKey("dbo.BookSubjects");
            DropPrimaryKey("dbo.Books");
            DropPrimaryKey("dbo.BookPublishers");
            DropPrimaryKey("dbo.BookAuthors");
            AlterColumn("dbo.Users", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Infractions", "User_Id", c => c.Guid());
            AlterColumn("dbo.Infractions", "Book_Id", c => c.Guid());
            AlterColumn("dbo.Infractions", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.BookSubjects", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.BookTypes", "Subject_Id", c => c.Guid());
            AlterColumn("dbo.BookTypes", "Publisher_Id", c => c.Guid());
            AlterColumn("dbo.BookTypes", "Author_Id", c => c.Guid());
            AlterColumn("dbo.Books", "User_Id", c => c.Guid());
            AlterColumn("dbo.Books", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.BookPublishers", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.BookAuthors", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "Id");
            AddPrimaryKey("dbo.Infractions", "Id");
            AddPrimaryKey("dbo.BookSubjects", "Id");
            AddPrimaryKey("dbo.Books", "Id");
            AddPrimaryKey("dbo.BookPublishers", "Id");
            AddPrimaryKey("dbo.BookAuthors", "Id");
            CreateIndex("dbo.Infractions", "User_Id");
            CreateIndex("dbo.Infractions", "Book_Id");
            CreateIndex("dbo.BookTypes", "Subject_Id");
            CreateIndex("dbo.BookTypes", "Publisher_Id");
            CreateIndex("dbo.BookTypes", "Author_Id");
            CreateIndex("dbo.Books", "User_Id");
            AddForeignKey("dbo.Infractions", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Books", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.BookTypes", "Subject_Id", "dbo.BookSubjects", "Id");
            AddForeignKey("dbo.Infractions", "Book_Id", "dbo.Books", "Id");
            AddForeignKey("dbo.BookTypes", "Publisher_Id", "dbo.BookPublishers", "Id");
            AddForeignKey("dbo.BookTypes", "Author_Id", "dbo.BookAuthors", "Id");
        }
    }
}
