namespace OuWebsiteTeam_RestaurantService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_v13_Foods : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PdbFoods", "PriceDiscountForSmallSize", c => c.Decimal(storeType: "money"));
            DropColumn("dbo.PdbFoods", "PersenDiscountForSmallSize");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PdbFoods", "PersenDiscountForSmallSize", c => c.Decimal(storeType: "money"));
            DropColumn("dbo.PdbFoods", "PriceDiscountForSmallSize");
        }
    }
}
