namespace _2015104916.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dassss : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cinturones", "CinturonId", "dbo.Asientos");
            DropIndex("dbo.Cinturones", new[] { "CinturonId" });
            AddColumn("dbo.Cinturones", "AsientoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cinturones", "AsientoId");
            AddForeignKey("dbo.Cinturones", "AsientoId", "dbo.Asientos", "AsientoId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cinturones", "AsientoId", "dbo.Asientos");
            DropIndex("dbo.Cinturones", new[] { "AsientoId" });
            DropColumn("dbo.Cinturones", "AsientoId");
            CreateIndex("dbo.Cinturones", "CinturonId");
            AddForeignKey("dbo.Cinturones", "CinturonId", "dbo.Asientos", "AsientoId");
        }
    }
}
