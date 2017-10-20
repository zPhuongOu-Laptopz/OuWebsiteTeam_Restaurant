namespace OuWebsiteTeam_RestaurantService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialCreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PdbBanners",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ImageName = c.Binary(storeType: "image"),
                        Type = c.String(nullable: false, maxLength: 50),
                        Link = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PdbBookTables",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 15),
                        Email = c.String(maxLength: 100),
                        NumberPerson = c.Int(nullable: false),
                        TypeRoom = c.String(nullable: false, maxLength: 100),
                        Time = c.DateTime(nullable: false),
                        Note = c.String(),
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
                        Type = c.String(nullable: false, maxLength: 100),
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
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PdbUser");
            DropTable("dbo.PdbRestaurants");
            DropTable("dbo.PdbFoods");
            DropTable("dbo.PdbFeedbacks");
            DropTable("dbo.PdbBookTables");
            DropTable("dbo.PdbBanners");
        }
    }
}
