namespace WebElReyCan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Turnoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Nombre = c.String(nullable: false),
                        Raza = c.String(),
                        Edad = c.Int(nullable: false),
                        NombreDuenio = c.String(nullable: false),
                        Celular = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Turnoes");
        }
    }
}
