namespace OuWebsiteTeam_RestaurantService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_v12_Foods : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PdbFoods", "PercentDiscountForSmallSize", c => c.Int(nullable: false));
            AddColumn("dbo.PdbFoods", "PercentDiscountForBigSize", c => c.Int(nullable: false));
            AddColumn("dbo.PdbFoods", "PersenDiscountForSmallSize", c => c.Decimal(storeType: "money"));
            AlterColumn("dbo.PdbFoods", "PriceBigSize", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.PdbFoods", "PriceSmallSize", c => c.Decimal(nullable: false, storeType: "money"));
            DropColumn("dbo.PdbFoods", "PriceDiscountForSmallSize");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PdbFoods", "PriceDiscountForSmallSize", c => c.Decimal(storeType: "money"));
            AlterColumn("dbo.PdbFoods", "PriceSmallSize", c => c.Decimal(storeType: "money"));
            AlterColumn("dbo.PdbFoods", "PriceBigSize", c => c.Decimal(storeType: "money"));
            DropColumn("dbo.PdbFoods", "PersenDiscountForSmallSize");
            DropColumn("dbo.PdbFoods", "PercentDiscountForBigSize");
            DropColumn("dbo.PdbFoods", "PercentDiscountForSmallSize");
        }
    }
}
