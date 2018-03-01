namespace MacroTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        FoodId = c.Int(nullable: false, identity: true),
                        FoodName = c.String(maxLength: 50),
                        FatGrams = c.Double(nullable: false),
                        CarbGrams = c.Double(nullable: false),
                        ProteinGrams = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.FoodId);
            
            CreateTable(
                "dbo.FoodsConsumeds",
                c => new
                    {
                        FoodsConsumedId = c.Int(nullable: false, identity: true),
                        ConsumedFoodName = c.String(maxLength: 50),
                        ConsumedFatGrams = c.Double(nullable: false),
                        ConsumedCarbGrams = c.Double(nullable: false),
                        ConsumedProteinGrams = c.Double(nullable: false),
                        DateConsumed = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FoodsConsumedId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FoodsConsumeds");
            DropTable("dbo.Foods");
        }
    }
}
