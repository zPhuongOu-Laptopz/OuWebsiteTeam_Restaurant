namespace OuWebsiteTeam_RestaurantService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase_v30 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PdbFoodCombo", "IDFood", "dbo.PdbFoods");
            DropForeignKey("dbo.PdbFoodMeterials", "IDMeterial", "dbo.PdbMeterials");
            DropForeignKey("dbo.PdbFoodMeterials", "IDFood", "dbo.PdbFoods");
            DropForeignKey("dbo.PdbFoodCombo", "IDCombo", "dbo.PdbCombo");
            DropIndex("dbo.PdbFoodCombo", new[] { "IDCombo" });
            DropIndex("dbo.PdbFoodCombo", new[] { "IDFood" });
            DropIndex("dbo.PdbFoodMeterials", new[] { "IDFood" });
            DropIndex("dbo.PdbFoodMeterials", new[] { "IDMeterial" });
            AddColumn("dbo.PdbFoods", "Type", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.PdbUser", "AccessFailedCount");
            DropColumn("dbo.PdbUser", "AccessCount");
            DropColumn("dbo.PdbUser", "AuthenticationSource");
            DropColumn("dbo.PdbUser", "Avatar");
            DropTable("dbo.PdbCombo");
            DropTable("dbo.PdbFoodCombo");
            DropTable("dbo.PdbFoodMeterials");
            DropTable("dbo.PdbMeterials");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PdbMeterials",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Origin = c.String(maxLength: 50),
                        Descriptions = c.String(maxLength: 250),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PdbFoodMeterials",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        IDFood = c.Guid(nullable: false),
                        IDMeterial = c.Guid(nullable: false),
                        IsStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID, t.IDFood, t.IDMeterial });
            
            CreateTable(
                "dbo.PdbFoodCombo",
                c => new
                    {
                        IDCombo = c.Guid(nullable: false),
                        IDFood = c.Guid(nullable: false),
                        IsStatus = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.IDCombo, t.IDFood });
            
            CreateTable(
                "dbo.PdbCombo",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Decriptions = c.String(nullable: false, maxLength: 250),
                        Code = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        OldPrice = c.Decimal(nullable: false, storeType: "money"),
                        RealPrice = c.Decimal(nullable: false, storeType: "money"),
                        OutDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreatedDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreatedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        Modifedby = c.Guid(),
                        IsStatus = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.PdbUser", "Avatar", c => c.String(maxLength: 50));
            AddColumn("dbo.PdbUser", "AuthenticationSource", c => c.Guid());
            AddColumn("dbo.PdbUser", "AccessCount", c => c.Int(nullable: false));
            AddColumn("dbo.PdbUser", "AccessFailedCount", c => c.Int(nullable: false));
            DropColumn("dbo.PdbFoods", "Type");
            CreateIndex("dbo.PdbFoodMeterials", "IDMeterial");
            CreateIndex("dbo.PdbFoodMeterials", "IDFood");
            CreateIndex("dbo.PdbFoodCombo", "IDFood");
            CreateIndex("dbo.PdbFoodCombo", "IDCombo");
            AddForeignKey("dbo.PdbFoodCombo", "IDCombo", "dbo.PdbCombo", "ID");
            AddForeignKey("dbo.PdbFoodMeterials", "IDFood", "dbo.PdbFoods", "ID");
            AddForeignKey("dbo.PdbFoodMeterials", "IDMeterial", "dbo.PdbMeterials", "ID");
            AddForeignKey("dbo.PdbFoodCombo", "IDFood", "dbo.PdbFoods", "ID");
        }
    }
}
