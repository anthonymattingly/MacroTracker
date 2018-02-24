namespace MacroTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02_24_2018 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Foods", new[] { "FoodsConsumed_FoodsConsumedId" });
            AddColumn("dbo.Foods", "HasEaten", c => c.Boolean(nullable: false));
            AddColumn("dbo.FoodsConsumeds", "ConsumedFoodName", c => c.String(maxLength: 50));
            AddColumn("dbo.FoodsConsumeds", "ConsumedFatGrams", c => c.Double(nullable: false));
            AddColumn("dbo.FoodsConsumeds", "ConsumedCarbGrams", c => c.Double(nullable: false));
            AddColumn("dbo.FoodsConsumeds", "ConsumedProteinGrams", c => c.Double(nullable: false));
            AddColumn("dbo.FoodsConsumeds", "FoodsConsumed_FoodsConsumedId", c => c.Int());
            CreateIndex("dbo.FoodsConsumeds", "FoodsConsumed_FoodsConsumedId");
            DropColumn("dbo.Foods", "FoodsConsumed_FoodsConsumedId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "FoodsConsumed_FoodsConsumedId", c => c.Int());
            DropIndex("dbo.FoodsConsumeds", new[] { "FoodsConsumed_FoodsConsumedId" });
            DropColumn("dbo.FoodsConsumeds", "FoodsConsumed_FoodsConsumedId");
            DropColumn("dbo.FoodsConsumeds", "ConsumedProteinGrams");
            DropColumn("dbo.FoodsConsumeds", "ConsumedCarbGrams");
            DropColumn("dbo.FoodsConsumeds", "ConsumedFatGrams");
            DropColumn("dbo.FoodsConsumeds", "ConsumedFoodName");
            DropColumn("dbo.Foods", "HasEaten");
            CreateIndex("dbo.Foods", "FoodsConsumed_FoodsConsumedId");
        }
    }
}
