namespace _2015104916.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carros", "Placa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Carros", "Placa");
        }
    }
}
