namespace ZovTable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTime2Fixing : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Details", "LastEditDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Details", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Details", "statusModfiedDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Orders", "AddedTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Orders", "LastEditDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Packs", "ShippedTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Packs", "AddedTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Packs", "LastEditDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Packs", "AcceptedTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Ships", "SDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Ships", "LastEditDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Ships", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ships", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Ships", "LastEditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Ships", "SDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Packs", "AcceptedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Packs", "LastEditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Packs", "AddedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Packs", "ShippedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "LastEditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "AddedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Details", "statusModfiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Details", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Details", "LastEditDate", c => c.DateTime(nullable: false));
        }
    }
}
