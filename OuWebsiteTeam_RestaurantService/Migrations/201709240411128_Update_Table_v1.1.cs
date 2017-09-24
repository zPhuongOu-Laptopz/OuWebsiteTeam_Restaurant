namespace OuWebsiteTeam_RestaurantService.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_v11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PdbCombo", "OutDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.PdbFoods", "PriceDiscountForSmallSize", c => c.Decimal(storeType: "money"));
            AddColumn("dbo.PdbFoods", "PriceDiscountForBigSize", c => c.Decimal(storeType: "money"));
            AddColumn("dbo.PdbEvents", "isStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.PdbFoods", "IsDiscountforBigZize");
            DropColumn("dbo.PdbFoods", "IsDiscountfotSmallSize");
            DropColumn("dbo.PdbFoods", "IsBigSize");
            DropColumn("dbo.PdbFoods", "IsSmallSize");
            DropColumn("dbo.PdbFoods", "IsBestSale");
            DropColumn("dbo.PdbFeedbacks", "NumberStar2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PdbFeedbacks", "NumberStar2", c => c.Int(nullable: false));
            AddColumn("dbo.PdbFoods", "IsBestSale", c => c.Boolean(nullable: false));
            AddColumn("dbo.PdbFoods", "IsSmallSize", c => c.Boolean(nullable: false));
            AddColumn("dbo.PdbFoods", "IsBigSize", c => c.Boolean(nullable: false));
            AddColumn("dbo.PdbFoods", "IsDiscountfotSmallSize", c => c.Boolean());
            AddColumn("dbo.PdbFoods", "IsDiscountforBigZize", c => c.Boolean());
            DropColumn("dbo.PdbEvents", "isStatus");
            DropColumn("dbo.PdbFoods", "PriceDiscountForBigSize");
            DropColumn("dbo.PdbFoods", "PriceDiscountForSmallSize");
            DropColumn("dbo.PdbCombo", "OutDate");
        }
    }
}
