namespace Otel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tabloladadegisiklikyapildi4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Oteller", "Adresi_Id", "dbo.İller");
            DropIndex("dbo.Oteller", new[] { "Adresi_Id" });
            AlterColumn("dbo.İlçeler", "IlceAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Mahalleler", "MahalleAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.İller", "IlADi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Musteriler", "Adi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Musteriler", "Soyadi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Musteriler", "TelefonNum", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Musteriler", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Musteriler", "TcKimlik", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Musteriler", "KullaniciAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Odalar", "OdaNumarası", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Oteller", "Adi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Oteller", "ResmiAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Oteller", "Aciklama", c => c.String(maxLength: 150));
            AlterColumn("dbo.Oteller", "Adresi_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Ozellikler", "OzellikAdi", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Oteller", "Adresi_Id");
            AddForeignKey("dbo.Oteller", "Adresi_Id", "dbo.İller", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Oteller", "Adresi_Id", "dbo.İller");
            DropIndex("dbo.Oteller", new[] { "Adresi_Id" });
            AlterColumn("dbo.Ozellikler", "OzellikAdi", c => c.String(nullable: false));
            AlterColumn("dbo.Oteller", "Adresi_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Oteller", "Aciklama", c => c.String());
            AlterColumn("dbo.Oteller", "ResmiAdi", c => c.String());
            AlterColumn("dbo.Oteller", "Adi", c => c.String());
            AlterColumn("dbo.Odalar", "OdaNumarası", c => c.String());
            AlterColumn("dbo.Musteriler", "KullaniciAdi", c => c.String());
            AlterColumn("dbo.Musteriler", "TcKimlik", c => c.String(nullable: false));
            AlterColumn("dbo.Musteriler", "Email", c => c.String());
            AlterColumn("dbo.Musteriler", "TelefonNum", c => c.String(maxLength: 11));
            AlterColumn("dbo.Musteriler", "Soyadi", c => c.String());
            AlterColumn("dbo.Musteriler", "Adi", c => c.String());
            AlterColumn("dbo.İller", "IlADi", c => c.String(nullable: false));
            AlterColumn("dbo.Mahalleler", "MahalleAdi", c => c.String());
            AlterColumn("dbo.İlçeler", "IlceAdi", c => c.String());
            CreateIndex("dbo.Oteller", "Adresi_Id");
            AddForeignKey("dbo.Oteller", "Adresi_Id", "dbo.İller", "Id");
        }
    }
}
