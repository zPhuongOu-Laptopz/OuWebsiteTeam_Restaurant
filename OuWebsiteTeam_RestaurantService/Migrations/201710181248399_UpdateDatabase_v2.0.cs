namespace OuWebsiteTeam_RestaurantService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase_v20 : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PdbBookTables");
        }
    }
}
