namespace Provider.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abonent",
                c => new
                    {
                        AbonentId = c.Int(nullable: false, identity: true),
                        TarifId = c.Int(nullable: false),
                        Name = c.String(maxLength: 50, unicode: false),
                        Address = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.AbonentId)
                .ForeignKey("dbo.Tarif", t => t.TarifId)
                .Index(t => t.TarifId);
            
            CreateTable(
                "dbo.Tarif",
                c => new
                    {
                        TarifId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Price = c.Int(nullable: false),
                        Discription = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.TarifId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Abonent", "TarifId", "dbo.Tarif");
            DropIndex("dbo.Abonent", new[] { "TarifId" });
            DropTable("dbo.Tarif");
            DropTable("dbo.Abonent");
        }
    }
}
