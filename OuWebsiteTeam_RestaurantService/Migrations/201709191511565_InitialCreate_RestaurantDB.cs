namespace OuWebsiteTeam_RestaurantService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate_RestaurantDB : DbMigration
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
                "dbo.PdbCategories",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        IsStatus = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreatedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        Modifedby = c.Guid(),
                        Filter = c.Int(nullable: false),
                        HtmlIcon = c.String(nullable: false, maxLength: 100),
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
                        CreatedDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreatedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        Modifedby = c.Guid(),
                        IsDisplay = c.Boolean(),
                        IsStatus = c.Boolean(),
                        BuyCount = c.Int(),
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
                        PriceBigSize = c.Decimal(storeType: "money"),
                        PriceSmallSize = c.Decimal(storeType: "money"),
                        CreatedDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreatedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        Modifedby = c.Guid(),
                        IsDiscountforBigZize = c.Boolean(),
                        IsDiscountfotSmallSize = c.Boolean(),
                        IsBigSize = c.Boolean(nullable: false),
                        IsSmallSize = c.Boolean(nullable: false),
                        IsStatus = c.Boolean(nullable: false),
                        IsBestSale = c.Boolean(nullable: false),
                        IsAllowOrder = c.Boolean(nullable: false),
                        IsHot = c.Boolean(nullable: false),
                        ViewCount = c.Int(nullable: false),
                        BuyCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PdbFoodHashtags",
                c => new
                    {
                        IDHashtag = c.Guid(nullable: false),
                        IDFood = c.Guid(nullable: false),
                        IsStatus = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.IDHashtag, t.IDFood })
                .ForeignKey("dbo.PdbHashtags", t => t.IDHashtag)
                .ForeignKey("dbo.PdbFoods", t => t.IDFood)
                .Index(t => t.IDHashtag)
                .Index(t => t.IDFood);
            
            CreateTable(
                "dbo.PdbHashtags",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 50),
                        IsStatus = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PdbFoodMeterials",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        IDFood = c.Guid(nullable: false),
                        IDMeterials = c.Guid(nullable: false),
                        IsStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID, t.IDFood, t.IDMeterials })
                .ForeignKey("dbo.PdbMeterials", t => t.IDMeterials)
                .ForeignKey("dbo.PdbFoods", t => t.IDFood)
                .Index(t => t.IDFood)
                .Index(t => t.IDMeterials);
            
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
                        Name = c.String(nullable: false, maxLength: 50),
                        Type = c.String(nullable: false, maxLength: 50),
                        Value = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PdbEvents",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Text = c.String(maxLength: 10, fixedLength: true),
                        CreatedDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreatedBy = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        Modifedby = c.Guid(),
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
                        Email = c.String(maxLength: 100),
                        Phone = c.String(maxLength: 15, fixedLength: true),
                        NumberStar2 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PdbImagesFoods",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        IDFoods = c.Guid(nullable: false),
                        ImageName = c.String(nullable: false, maxLength: 50),
                        Link = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PdbImagesRestaurants",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        IDRes = c.Guid(nullable: false),
                        ImageName = c.String(nullable: false, maxLength: 50),
                        Link = c.String(maxLength: 100),
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
            DropForeignKey("dbo.PdbFoodMeterials", "IDMeterials", "dbo.PdbMeterials");
            DropForeignKey("dbo.PdbFoodHashtags", "IDFood", "dbo.PdbFoods");
            DropForeignKey("dbo.PdbFoodHashtags", "IDHashtag", "dbo.PdbHashtags");
            DropForeignKey("dbo.PdbFoodCombo", "IDFood", "dbo.PdbFoods");
            DropIndex("dbo.PdbFoodMeterials", new[] { "IDMeterials" });
            DropIndex("dbo.PdbFoodMeterials", new[] { "IDFood" });
            DropIndex("dbo.PdbFoodHashtags", new[] { "IDFood" });
            DropIndex("dbo.PdbFoodHashtags", new[] { "IDHashtag" });
            DropIndex("dbo.PdbFoodCombo", new[] { "IDFood" });
            DropIndex("dbo.PdbFoodCombo", new[] { "IDCombo" });
            DropTable("dbo.PdbUser");
            DropTable("dbo.PdbRestaurants");
            DropTable("dbo.PdbImagesRestaurants");
            DropTable("dbo.PdbImagesFoods");
            DropTable("dbo.PdbFeedbacks");
            DropTable("dbo.PdbEvents");
            DropTable("dbo.PdbContacts");
            DropTable("dbo.PdbMeterials");
            DropTable("dbo.PdbFoodMeterials");
            DropTable("dbo.PdbHashtags");
            DropTable("dbo.PdbFoodHashtags");
            DropTable("dbo.PdbFoods");
            DropTable("dbo.PdbFoodCombo");
            DropTable("dbo.PdbCombo");
            DropTable("dbo.PdbCategories");
            DropTable("dbo.PdbBanners");
        }
    }
}
