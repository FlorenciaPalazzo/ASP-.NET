namespace SistemaWebTransporte.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreacionDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Modelo = c.String(nullable: false),
                        Marca = c.String(nullable: false),
                        Anio = c.Int(nullable: false),
                        Color = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Auto");
        }
    }
}
