namespace MacroTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FoodsConsumedDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodsConsumeds",
                c => new
                    {
                        FoodsConsumedId = c.Int(nullable: false, identity: true),
                        DateConsumed = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FoodsConsumedId);
            
            AddColumn("dbo.Foods", "FoodsConsumed_FoodsConsumedId", c => c.Int());
            CreateIndex("dbo.Foods", "FoodsConsumed_FoodsConsumedId");
            AddForeignKey("dbo.Foods", "FoodsConsumed_FoodsConsumedId", "dbo.FoodsConsumeds", "FoodsConsumedId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "FoodsConsumed_FoodsConsumedId", "dbo.FoodsConsumeds");
            DropIndex("dbo.Foods", new[] { "FoodsConsumed_FoodsConsumedId" });
            DropColumn("dbo.Foods", "FoodsConsumed_FoodsConsumedId");
            DropTable("dbo.FoodsConsumeds");
        }
    }
}
