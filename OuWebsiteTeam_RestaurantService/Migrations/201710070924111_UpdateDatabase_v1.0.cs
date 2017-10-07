namespace OuWebsiteTeam_RestaurantService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase_v10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PdbBanners",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ImageName = c.String(nullable: false, maxLength: 50),
                        Type = c.String(nullable: false, maxLength: 50),
                        Link = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
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
            
            CreateTable(
                "dbo.PdbFoodCombo",
                c => new
                    {
                        IDCombo = c.Guid(nullable: false),
                        IDFood = c.Guid(nullable: false),
                        IsStatus = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.IDCombo, t.IDFood })
                .ForeignKey("dbo.PdbFoods", t => t.IDFood)
                .ForeignKey("dbo.PdbCombo", t => t.IDCombo)
                .Index(t => t.IDCombo)
                .Index(t => t.IDFood);
            
            CreateTable(
                "dbo.PdbFoods",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        NameFood = c.String(nullable: false, maxLength: 100),
                        Decriptions = c.String(nullable: false, maxLength: 100),
                        Images = c.Binary(storeType: "image"),
                        PriceBigSize = c.Decimal(nullable: false, storeType: "money"),
                        PriceSmallSize = c.Decimal(nullable: false, storeType: "money"),
                        PercentDiscountForBigSize = c.Int(nullable: false),
                        PercentDiscountForSmallSize = c.Int(nullable: false),
                        PriceDiscountForBigSize = c.Decimal(storeType: "money"),
                        PriceDiscountForSmallSize = c.Decimal(storeType: "money"),
                        CreatedDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreatedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        Modifedby = c.Guid(),
                        IsStatus = c.Boolean(nullable: false),
                        IsAllowOrder = c.Boolean(nullable: false),
                        IsHot = c.Boolean(nullable: false),
                        ViewCount = c.Int(nullable: false),
                        BuyCount = c.Int(nullable: false),
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
                .PrimaryKey(t => new { t.ID, t.IDFood, t.IDMeterial })
                .ForeignKey("dbo.PdbMeterials", t => t.IDMeterial)
                .ForeignKey("dbo.PdbFoods", t => t.IDFood)
                .Index(t => t.IDFood)
                .Index(t => t.IDMeterial);
            
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
                "dbo.PdbContacts",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        NunberPhone = c.String(maxLength: 15, fixedLength: true),
                        isAllowMail = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PdbFeedbacks",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        NumberStar = c.Int(nullable: false),
                        Message = c.String(),
                        Email = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(maxLength: 15, fixedLength: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PdbRestaurants",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        RealName = c.String(nullable: false, maxLength: 100),
                        ShortName = c.String(maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 100),
                        FacebookAddress = c.String(nullable: false, maxLength: 100),
                        InstagramAddress = c.String(nullable: false, maxLength: 100),
                        YoutubeAddress = c.String(maxLength: 100),
                        TwitterAddress = c.String(maxLength: 100),
                        Decriptions = c.String(nullable: false, maxLength: 250),
                        Phone = c.String(nullable: false, maxLength: 15, fixedLength: true),
                        Fax = c.String(nullable: false, maxLength: 15, fixedLength: true),
                        NumberStar = c.Int(nullable: false),
                        TimeOpen = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        TimeClose = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        LocationGoogleMap = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PdbUser",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Username = c.String(nullable: false, maxLength: 30, fixedLength: true),
                        Password = c.String(nullable: false, maxLength: 30, fixedLength: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        EmailAddress = c.String(nullable: false, maxLength: 256),
                        PhoneNumber = c.String(nullable: false, maxLength: 15, fixedLength: true),
                        LastLoginTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreatedDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreatedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        ModifiedBy = c.Guid(),
                        isActive = c.Boolean(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        AccessCount = c.Int(nullable: false),
                        AuthenticationSource = c.Guid(),
                        Avatar = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PdbFoodCombo", "IDCombo", "dbo.PdbCombo");
            DropForeignKey("dbo.PdbFoodMeterials", "IDFood", "dbo.PdbFoods");
            DropForeignKey("dbo.PdbFoodMeterials", "IDMeterial", "dbo.PdbMeterials");
            DropForeignKey("dbo.PdbFoodCombo", "IDFood", "dbo.PdbFoods");
            DropIndex("dbo.PdbFoodMeterials", new[] { "IDMeterial" });
            DropIndex("dbo.PdbFoodMeterials", new[] { "IDFood" });
            DropIndex("dbo.PdbFoodCombo", new[] { "IDFood" });
            DropIndex("dbo.PdbFoodCombo", new[] { "IDCombo" });
            DropTable("dbo.PdbUser");
            DropTable("dbo.PdbRestaurants");
            DropTable("dbo.PdbFeedbacks");
            DropTable("dbo.PdbContacts");
            DropTable("dbo.PdbMeterials");
            DropTable("dbo.PdbFoodMeterials");
            DropTable("dbo.PdbFoods");
            DropTable("dbo.PdbFoodCombo");
            DropTable("dbo.PdbCombo");
            DropTable("dbo.PdbBanners");
        }
    }
}
