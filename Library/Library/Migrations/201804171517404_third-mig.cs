namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdmig : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.People", name: "Phone", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.People", name: "Address", newName: "__mig_tmp__1");
            RenameColumn(table: "dbo.People", name: "Phone1", newName: "Phone");
            RenameColumn(table: "dbo.People", name: "Address1", newName: "Address");
            RenameColumn(table: "dbo.People", name: "__mig_tmp__0", newName: "Phone1");
            RenameColumn(table: "dbo.People", name: "__mig_tmp__1", newName: "Address1");
            AddColumn("dbo.People", "FullName", c => c.String());
            AlterColumn("dbo.Cities", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cities", "Name", c => c.String());
            DropColumn("dbo.People", "FullName");
            RenameColumn(table: "dbo.People", name: "Address1", newName: "__mig_tmp__1");
            RenameColumn(table: "dbo.People", name: "Phone1", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.People", name: "Address", newName: "Address1");
            RenameColumn(table: "dbo.People", name: "Phone", newName: "Phone1");
            RenameColumn(table: "dbo.People", name: "__mig_tmp__1", newName: "Address");
            RenameColumn(table: "dbo.People", name: "__mig_tmp__0", newName: "Phone");
        }
    }
}
