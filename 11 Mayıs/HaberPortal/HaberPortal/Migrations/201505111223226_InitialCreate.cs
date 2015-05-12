namespace HaberPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Haberler",
                c => new
                    {
                        HaberId = c.Int(nullable: false, identity: true),
                        HaberBaslik = c.String(nullable: false, maxLength: 100),
                        HaberIcerik = c.String(),
                        Kategorisi_KategoriId = c.Int(),
                    })
                .PrimaryKey(t => t.HaberId)
                .ForeignKey("dbo.Kategoriler", t => t.Kategorisi_KategoriId)
                .Index(t => t.Kategorisi_KategoriId);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 50),
                        Aciklamasi = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.KategoriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Haberler", "Kategorisi_KategoriId", "dbo.Kategoriler");
            DropIndex("dbo.Haberler", new[] { "Kategorisi_KategoriId" });
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Haberler");
        }
    }
}
