namespace ZovTable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        DetailID = c.Int(nullable: false),
                        IncomeID = c.Int(nullable: false),
                        Customer = c.String(),
                        Number = c.String(),
                        ColorName = c.String(),
                        ArticleName = c.String(),
                        Qty = c.Int(nullable: false),
                        GTIN = c.Int(nullable: false),
                        Serial = c.Int(nullable: false),
                        LastEditDate = c.DateTime(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        ForeignID = c.String(),
                        Status = c.Int(nullable: false),
                        statusModfiedDate = c.DateTime(nullable: false),
                        Length = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                        Texture = c.Int(nullable: false),
                        Edge = c.String(),
                        Taping = c.Int(nullable: false),
                        Shape = c.String(),
                        Pallet = c.String(),
                        Rounding = c.String(),
                        Thickness = c.Int(nullable: false),
                        EdgeName = c.String(),
                        CathetusL = c.Int(nullable: false),
                        CathetusW = c.Int(nullable: false),
                        waterproof = c.Int(nullable: false),
                        FrezR = c.Int(nullable: false),
                        x = c.Single(nullable: false),
                        y = c.Single(nullable: false),
                        Pack_Key = c.Int(),
                    })
                .PrimaryKey(t => t.Key)
                .ForeignKey("dbo.Packs", t => t.Pack_Key)
                .Index(t => t.Pack_Key);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        GTIN = c.Int(nullable: false),
                        ShipID = c.Int(nullable: false),
                        Customer = c.String(),
                        Number = c.String(),
                        Qty = c.Int(nullable: false),
                        AddedBy = c.String(),
                        AddedTime = c.DateTime(nullable: false),
                        LastEditDate = c.DateTime(nullable: false),
                        rowguid = c.String(),
                        orderOUID = c.String(),
                        ispacked = c.Int(nullable: false),
                        foreignOrderId_int = c.Int(nullable: false),
                        Note = c.String(),
                        foreignOrderId = c.String(),
                        Ship_Key = c.Int(),
                    })
                .PrimaryKey(t => t.Key)
                .ForeignKey("dbo.Ships", t => t.Ship_Key)
                .Index(t => t.Ship_Key);
            
            CreateTable(
                "dbo.Packs",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        Serial = c.Int(nullable: false),
                        GTIN = c.Int(nullable: false),
                        TaskID = c.Int(nullable: false),
                        OrderID = c.Int(nullable: false),
                        RegTime = c.DateTime(nullable: false),
                        RegBy = c.String(),
                        RegAuto = c.Boolean(nullable: false),
                        ShippedTime = c.DateTime(nullable: false),
                        ShippedBy = c.String(),
                        ShippedAuto = c.Boolean(nullable: false),
                        AddedBy = c.String(),
                        AddedTime = c.DateTime(nullable: false),
                        LastEditDate = c.DateTime(nullable: false),
                        rowguid = c.String(),
                        isprinted = c.Int(nullable: false),
                        driverShip = c.Int(nullable: false),
                        isSended = c.Boolean(nullable: false),
                        isInsight = c.Boolean(nullable: false),
                        isInsightPacked = c.Boolean(nullable: false),
                        isInsightShipped = c.Boolean(nullable: false),
                        AcceptedAuto = c.Boolean(nullable: false),
                        AcceptedBy = c.String(),
                        AcceptedTime = c.DateTime(nullable: false),
                        Order_Key = c.Int(),
                    })
                .PrimaryKey(t => t.Key)
                .ForeignKey("dbo.Orders", t => t.Order_Key)
                .Index(t => t.Order_Key);
            
            CreateTable(
                "dbo.Ships",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        ShipID = c.Int(nullable: false),
                        SDate = c.DateTime(nullable: false),
                        Note = c.String(),
                        State = c.Int(nullable: false),
                        LastEditDate = c.DateTime(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        rowguid = c.String(),
                        shipFromSborka = c.Boolean(nullable: false),
                        CreateUser = c.String(),
                    })
                .PrimaryKey(t => t.Key);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Ship_Key", "dbo.Ships");
            DropForeignKey("dbo.Packs", "Order_Key", "dbo.Orders");
            DropForeignKey("dbo.Details", "Pack_Key", "dbo.Packs");
            DropIndex("dbo.Packs", new[] { "Order_Key" });
            DropIndex("dbo.Orders", new[] { "Ship_Key" });
            DropIndex("dbo.Details", new[] { "Pack_Key" });
            DropTable("dbo.Ships");
            DropTable("dbo.Packs");
            DropTable("dbo.Orders");
            DropTable("dbo.Details");
        }
    }
}
