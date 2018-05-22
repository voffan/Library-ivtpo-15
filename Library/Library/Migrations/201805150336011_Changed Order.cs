namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedOrder : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "LendingID", "dbo.Lendings");
            DropForeignKey("dbo.Orders", "ReadingRoomID", "dbo.ReadingRooms");
            DropIndex("dbo.Orders", new[] { "LendingID" });
            DropIndex("dbo.Orders", new[] { "ReadingRoomID" });
            AddColumn("dbo.Orders", "GotInReadingRoom", c => c.Boolean(nullable: false));
            DropColumn("dbo.Orders", "LendingID");
            DropColumn("dbo.Orders", "ReadingRoomID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "ReadingRoomID", c => c.Int());
            AddColumn("dbo.Orders", "LendingID", c => c.Int());
            DropColumn("dbo.Orders", "GotInReadingRoom");
            CreateIndex("dbo.Orders", "ReadingRoomID");
            CreateIndex("dbo.Orders", "LendingID");
            AddForeignKey("dbo.Orders", "ReadingRoomID", "dbo.ReadingRooms", "ReadingRoomID");
            AddForeignKey("dbo.Orders", "LendingID", "dbo.Lendings", "LendingID");
        }
    }
}
