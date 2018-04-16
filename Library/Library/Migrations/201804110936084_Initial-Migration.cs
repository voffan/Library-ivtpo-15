namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MiddleName = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        AuthorID = c.Int(),
                        CountryID = c.Int(),
                        Death_date = c.DateTime(),
                        ReaderID = c.Int(),
                        Phone = c.String(),
                        Address = c.String(),
                        LibrarianID = c.Int(),
                        PositionID = c.Int(),
                        UserID = c.Int(),
                        Phone1 = c.String(),
                        Address1 = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .ForeignKey("dbo.Positions", t => t.PositionID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.CountryID)
                .Index(t => t.PositionID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Author_PersonID = c.Int(),
                        Genre_GenreID = c.Int(),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.People", t => t.Author_PersonID)
                .ForeignKey("dbo.Genres", t => t.Genre_GenreID)
                .Index(t => t.Author_PersonID)
                .Index(t => t.Genre_GenreID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CountryID);
            
            CreateTable(
                "dbo.BookStatus",
                c => new
                    {
                        BookStatusID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BookStatusID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CountryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityID)
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .Index(t => t.CountryID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.Lendings",
                c => new
                    {
                        LendingID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.LendingID);
            
            CreateTable(
                "dbo.libraries",
                c => new
                    {
                        LibraryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.LibraryID);
            
            CreateTable(
                "dbo.OrderBooks",
                c => new
                    {
                        OrderBooksID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        BookID = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        BookStatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderBooksID)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .ForeignKey("dbo.BookStatus", t => t.BookStatusID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.BookID)
                .Index(t => t.BookStatusID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(),
                        IsReturned = c.Boolean(nullable: false),
                        BookID = c.Int(nullable: false),
                        ReaderID = c.Int(nullable: false),
                        LendingID = c.Int(),
                        ReadingRoomID = c.Int(),
                        Reader_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .ForeignKey("dbo.Lendings", t => t.LendingID)
                .ForeignKey("dbo.People", t => t.Reader_PersonID)
                .ForeignKey("dbo.ReadingRooms", t => t.ReadingRoomID)
                .Index(t => t.BookID)
                .Index(t => t.LendingID)
                .Index(t => t.ReadingRoomID)
                .Index(t => t.Reader_PersonID);
            
            CreateTable(
                "dbo.ReadingRooms",
                c => new
                    {
                        ReadingRoomID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ReadingRoomID);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PositionID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        PublisherID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CityID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PublisherID)
                .ForeignKey("dbo.Cities", t => t.CityID, cascadeDelete: true)
                .Index(t => t.CityID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Publishers", "CityID", "dbo.Cities");
            DropForeignKey("dbo.People", "UserID", "dbo.Users");
            DropForeignKey("dbo.People", "PositionID", "dbo.Positions");
            DropForeignKey("dbo.OrderBooks", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ReadingRoomID", "dbo.ReadingRooms");
            DropForeignKey("dbo.Orders", "Reader_PersonID", "dbo.People");
            DropForeignKey("dbo.Orders", "LendingID", "dbo.Lendings");
            DropForeignKey("dbo.Orders", "BookID", "dbo.Books");
            DropForeignKey("dbo.OrderBooks", "BookStatusID", "dbo.BookStatus");
            DropForeignKey("dbo.OrderBooks", "BookID", "dbo.Books");
            DropForeignKey("dbo.Books", "Genre_GenreID", "dbo.Genres");
            DropForeignKey("dbo.Cities", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.People", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.Books", "Author_PersonID", "dbo.People");
            DropIndex("dbo.Publishers", new[] { "CityID" });
            DropIndex("dbo.Orders", new[] { "Reader_PersonID" });
            DropIndex("dbo.Orders", new[] { "ReadingRoomID" });
            DropIndex("dbo.Orders", new[] { "LendingID" });
            DropIndex("dbo.Orders", new[] { "BookID" });
            DropIndex("dbo.OrderBooks", new[] { "BookStatusID" });
            DropIndex("dbo.OrderBooks", new[] { "BookID" });
            DropIndex("dbo.OrderBooks", new[] { "OrderID" });
            DropIndex("dbo.Cities", new[] { "CountryID" });
            DropIndex("dbo.Books", new[] { "Genre_GenreID" });
            DropIndex("dbo.Books", new[] { "Author_PersonID" });
            DropIndex("dbo.People", new[] { "UserID" });
            DropIndex("dbo.People", new[] { "PositionID" });
            DropIndex("dbo.People", new[] { "CountryID" });
            DropTable("dbo.Publishers");
            DropTable("dbo.Users");
            DropTable("dbo.Positions");
            DropTable("dbo.ReadingRooms");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderBooks");
            DropTable("dbo.libraries");
            DropTable("dbo.Lendings");
            DropTable("dbo.Genres");
            DropTable("dbo.Cities");
            DropTable("dbo.BookStatus");
            DropTable("dbo.Countries");
            DropTable("dbo.Books");
            DropTable("dbo.People");
        }
    }
}
