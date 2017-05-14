namespace _2015104916.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asientos",
                c => new
                    {
                        AsientoId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        CinturonId = c.Int(nullable: false),
                        CarroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AsientoId)
                .ForeignKey("dbo.Carros", t => t.CarroId, cascadeDelete: true)
                .Index(t => t.CarroId);
            
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        CarroId = c.Int(nullable: false),
                        NumSerieMotor = c.String(),
                        NumSerieChasis = c.String(),
                        EnsambladoraId = c.Int(nullable: false),
                        TipoCarro = c.Int(nullable: false),
                        TipoBus = c.Int(nullable: false),
                        TipoAuto = c.Int(nullable: false),
                        PropietarioId = c.Int(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CarroId)
                .ForeignKey("dbo.Ensambladoras", t => t.EnsambladoraId, cascadeDelete: true)
                .ForeignKey("dbo.Propietarios", t => t.CarroId)
                .Index(t => t.CarroId)
                .Index(t => t.EnsambladoraId);
            
            CreateTable(
                "dbo.Ensambladoras",
                c => new
                    {
                        EnsambladoraId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EnsambladoraId);
            
            CreateTable(
                "dbo.Llantas",
                c => new
                    {
                        LlantaId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        CarroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LlantaId)
                .ForeignKey("dbo.Carros", t => t.CarroId, cascadeDelete: true)
                .Index(t => t.CarroId);
            
            CreateTable(
                "dbo.Parabrisas",
                c => new
                    {
                        ParabrisasId = c.Int(nullable: false),
                        NumSerie = c.String(),
                        CarroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ParabrisasId)
                .ForeignKey("dbo.Carros", t => t.ParabrisasId)
                .Index(t => t.ParabrisasId);
            
            CreateTable(
                "dbo.Propietarios",
                c => new
                    {
                        PropietarioId = c.Int(nullable: false, identity: true),
                        Dni = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        Licencia = c.String(),
                        CarroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PropietarioId);
            
            CreateTable(
                "dbo.Volantes",
                c => new
                    {
                        VolanteId = c.Int(nullable: false),
                        NumSerie = c.String(),
                        CarroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VolanteId)
                .ForeignKey("dbo.Carros", t => t.VolanteId)
                .Index(t => t.VolanteId);
            
            CreateTable(
                "dbo.Cinturones",
                c => new
                    {
                        CinturonId = c.Int(nullable: false),
                        NumSerie = c.String(),
                        Metraje = c.Int(nullable: false),
                        AsientoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CinturonId)
                .ForeignKey("dbo.Asientos", t => t.CinturonId)
                .Index(t => t.CinturonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cinturones", "CinturonId", "dbo.Asientos");
            DropForeignKey("dbo.Asientos", "CarroId", "dbo.Carros");
            DropForeignKey("dbo.Volantes", "VolanteId", "dbo.Carros");
            DropForeignKey("dbo.Carros", "CarroId", "dbo.Propietarios");
            DropForeignKey("dbo.Parabrisas", "ParabrisasId", "dbo.Carros");
            DropForeignKey("dbo.Llantas", "CarroId", "dbo.Carros");
            DropForeignKey("dbo.Carros", "EnsambladoraId", "dbo.Ensambladoras");
            DropIndex("dbo.Cinturones", new[] { "CinturonId" });
            DropIndex("dbo.Volantes", new[] { "VolanteId" });
            DropIndex("dbo.Parabrisas", new[] { "ParabrisasId" });
            DropIndex("dbo.Llantas", new[] { "CarroId" });
            DropIndex("dbo.Carros", new[] { "EnsambladoraId" });
            DropIndex("dbo.Carros", new[] { "CarroId" });
            DropIndex("dbo.Asientos", new[] { "CarroId" });
            DropTable("dbo.Cinturones");
            DropTable("dbo.Volantes");
            DropTable("dbo.Propietarios");
            DropTable("dbo.Parabrisas");
            DropTable("dbo.Llantas");
            DropTable("dbo.Ensambladoras");
            DropTable("dbo.Carros");
            DropTable("dbo.Asientos");
        }
    }
}
