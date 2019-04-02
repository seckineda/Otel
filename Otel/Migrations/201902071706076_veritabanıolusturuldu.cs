namespace Otel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class veritabanıolusturuldu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ilces",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        IlceAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmatTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Il_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ils", t => t.Il_Id)
                .Index(t => t.Il_Id);
            
            CreateTable(
                "dbo.Mahalles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        MahalleAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmatTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Ilce_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ilces", t => t.Ilce_Id)
                .Index(t => t.Ilce_Id);
            
            CreateTable(
                "dbo.Ils",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        IlADi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmatTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        Sifre = c.Int(nullable: false),
                        TelefonNum = c.String(),
                        Email = c.String(),
                        TcKimlik = c.String(),
                        KullaniciAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmatTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Odas",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        odaSayisi = c.Int(nullable: false),
                        BosMu = c.Boolean(nullable: false),
                        Ucret = c.Int(nullable: false),
                        OdaNumarası = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmatTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        OtelId_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.OtelId_Id)
                .Index(t => t.OtelId_Id);
            
            CreateTable(
                "dbo.Otels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        VergiNo = c.Int(nullable: false),
                        Adi = c.String(),
                        ResmiAdi = c.String(),
                        Aciklama = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmatTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Adresi_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ils", t => t.Adresi_Id)
                .Index(t => t.Adresi_Id);
            
            CreateTable(
                "dbo.Yıldız",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        BegenmeSayisi = c.Int(nullable: false),
                        BegenmemeSayisi = c.Int(nullable: false),
                        OlusturanKisi = c.String(),
                        OlusturmatTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Otel_Id = c.String(maxLength: 128),
                        Yorum_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.Otel_Id)
                .ForeignKey("dbo.Yorums", t => t.Yorum_Id)
                .Index(t => t.Otel_Id)
                .Index(t => t.Yorum_Id);
            
            CreateTable(
                "dbo.Yorums",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        MusteriId = c.Int(nullable: false),
                        YorumBasligi = c.String(),
                        Yorumİcerigi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmatTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Otel_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.Otel_Id)
                .Index(t => t.Otel_Id);
            
            CreateTable(
                "dbo.OtelOzelligis",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OlusturanKisi = c.String(),
                        OlusturmatTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        OtelId_Id = c.String(maxLength: 128),
                        OzellikId_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.OtelId_Id)
                .ForeignKey("dbo.Ozelliks", t => t.OzellikId_Id)
                .Index(t => t.OtelId_Id)
                .Index(t => t.OzellikId_Id);
            
            CreateTable(
                "dbo.Ozelliks",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OzellikAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmatTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OtelResimleris",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OlusturanKisi = c.String(),
                        OlusturmatTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        OtelId_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.OtelId_Id)
                .Index(t => t.OtelId_Id);
            
            CreateTable(
                "dbo.Rezervasyons",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        KisiSayisi = c.Int(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(),
                        OlusturmatTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        MusteriId_Id = c.String(maxLength: 128),
                        OdaId_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Musteris", t => t.MusteriId_Id)
                .ForeignKey("dbo.Odas", t => t.OdaId_Id)
                .Index(t => t.MusteriId_Id)
                .Index(t => t.OdaId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezervasyons", "OdaId_Id", "dbo.Odas");
            DropForeignKey("dbo.Rezervasyons", "MusteriId_Id", "dbo.Musteris");
            DropForeignKey("dbo.OtelResimleris", "OtelId_Id", "dbo.Otels");
            DropForeignKey("dbo.OtelOzelligis", "OzellikId_Id", "dbo.Ozelliks");
            DropForeignKey("dbo.OtelOzelligis", "OtelId_Id", "dbo.Otels");
            DropForeignKey("dbo.Odas", "OtelId_Id", "dbo.Otels");
            DropForeignKey("dbo.Yorums", "Otel_Id", "dbo.Otels");
            DropForeignKey("dbo.Yıldız", "Yorum_Id", "dbo.Yorums");
            DropForeignKey("dbo.Yıldız", "Otel_Id", "dbo.Otels");
            DropForeignKey("dbo.Otels", "Adresi_Id", "dbo.Ils");
            DropForeignKey("dbo.Ilces", "Il_Id", "dbo.Ils");
            DropForeignKey("dbo.Mahalles", "Ilce_Id", "dbo.Ilces");
            DropIndex("dbo.Rezervasyons", new[] { "OdaId_Id" });
            DropIndex("dbo.Rezervasyons", new[] { "MusteriId_Id" });
            DropIndex("dbo.OtelResimleris", new[] { "OtelId_Id" });
            DropIndex("dbo.OtelOzelligis", new[] { "OzellikId_Id" });
            DropIndex("dbo.OtelOzelligis", new[] { "OtelId_Id" });
            DropIndex("dbo.Yorums", new[] { "Otel_Id" });
            DropIndex("dbo.Yıldız", new[] { "Yorum_Id" });
            DropIndex("dbo.Yıldız", new[] { "Otel_Id" });
            DropIndex("dbo.Otels", new[] { "Adresi_Id" });
            DropIndex("dbo.Odas", new[] { "OtelId_Id" });
            DropIndex("dbo.Mahalles", new[] { "Ilce_Id" });
            DropIndex("dbo.Ilces", new[] { "Il_Id" });
            DropTable("dbo.Rezervasyons");
            DropTable("dbo.OtelResimleris");
            DropTable("dbo.Ozelliks");
            DropTable("dbo.OtelOzelligis");
            DropTable("dbo.Yorums");
            DropTable("dbo.Yıldız");
            DropTable("dbo.Otels");
            DropTable("dbo.Odas");
            DropTable("dbo.Musteris");
            DropTable("dbo.Ils");
            DropTable("dbo.Mahalles");
            DropTable("dbo.Ilces");
        }
    }
}
