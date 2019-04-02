namespace Otel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tabloladadegisiklikyapildi3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Otel Özellikleri", "OtelId_Id", "dbo.Oteller");
            DropForeignKey("dbo.Otel Özellikleri", "OzellikId_Id", "dbo.Ozellikler");
            DropForeignKey("dbo.Otel Resimleri", "OtelId_Id", "dbo.Oteller");
            DropForeignKey("dbo.Rezervasyonlar", "MusteriId_Id", "dbo.Musteriler");
            DropForeignKey("dbo.Rezervasyonlar", "OdaId_Id", "dbo.Odalar");
            DropIndex("dbo.Otel Özellikleri", new[] { "OtelId_Id" });
            DropIndex("dbo.Otel Özellikleri", new[] { "OzellikId_Id" });
            DropIndex("dbo.Otel Resimleri", new[] { "OtelId_Id" });
            DropIndex("dbo.Rezervasyonlar", new[] { "MusteriId_Id" });
            DropIndex("dbo.Rezervasyonlar", new[] { "OdaId_Id" });
            AddColumn("dbo.Yorumlar", "MusteriId_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.İller", "IlADi", c => c.String(nullable: false));
            AlterColumn("dbo.Otel Özellikleri", "OtelId_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Otel Özellikleri", "OzellikId_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Ozellikler", "OzellikAdi", c => c.String(nullable: false));
            AlterColumn("dbo.Otel Resimleri", "OtelId_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Rezervasyonlar", "MusteriId_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Rezervasyonlar", "OdaId_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Yorumlar", "MusteriId_Id");
            CreateIndex("dbo.Otel Özellikleri", "OtelId_Id");
            CreateIndex("dbo.Otel Özellikleri", "OzellikId_Id");
            CreateIndex("dbo.Otel Resimleri", "OtelId_Id");
            CreateIndex("dbo.Rezervasyonlar", "MusteriId_Id");
            CreateIndex("dbo.Rezervasyonlar", "OdaId_Id");
            AddForeignKey("dbo.Yorumlar", "MusteriId_Id", "dbo.Musteriler", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Otel Özellikleri", "OtelId_Id", "dbo.Oteller", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Otel Özellikleri", "OzellikId_Id", "dbo.Ozellikler", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Otel Resimleri", "OtelId_Id", "dbo.Oteller", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rezervasyonlar", "MusteriId_Id", "dbo.Musteriler", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rezervasyonlar", "OdaId_Id", "dbo.Odalar", "Id", cascadeDelete: true);
            DropColumn("dbo.Yorumlar", "MusteriId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Yorumlar", "MusteriId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Rezervasyonlar", "OdaId_Id", "dbo.Odalar");
            DropForeignKey("dbo.Rezervasyonlar", "MusteriId_Id", "dbo.Musteriler");
            DropForeignKey("dbo.Otel Resimleri", "OtelId_Id", "dbo.Oteller");
            DropForeignKey("dbo.Otel Özellikleri", "OzellikId_Id", "dbo.Ozellikler");
            DropForeignKey("dbo.Otel Özellikleri", "OtelId_Id", "dbo.Oteller");
            DropForeignKey("dbo.Yorumlar", "MusteriId_Id", "dbo.Musteriler");
            DropIndex("dbo.Rezervasyonlar", new[] { "OdaId_Id" });
            DropIndex("dbo.Rezervasyonlar", new[] { "MusteriId_Id" });
            DropIndex("dbo.Otel Resimleri", new[] { "OtelId_Id" });
            DropIndex("dbo.Otel Özellikleri", new[] { "OzellikId_Id" });
            DropIndex("dbo.Otel Özellikleri", new[] { "OtelId_Id" });
            DropIndex("dbo.Yorumlar", new[] { "MusteriId_Id" });
            AlterColumn("dbo.Rezervasyonlar", "OdaId_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Rezervasyonlar", "MusteriId_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Otel Resimleri", "OtelId_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Ozellikler", "OzellikAdi", c => c.String());
            AlterColumn("dbo.Otel Özellikleri", "OzellikId_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Otel Özellikleri", "OtelId_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.İller", "IlADi", c => c.String());
            DropColumn("dbo.Yorumlar", "MusteriId_Id");
            CreateIndex("dbo.Rezervasyonlar", "OdaId_Id");
            CreateIndex("dbo.Rezervasyonlar", "MusteriId_Id");
            CreateIndex("dbo.Otel Resimleri", "OtelId_Id");
            CreateIndex("dbo.Otel Özellikleri", "OzellikId_Id");
            CreateIndex("dbo.Otel Özellikleri", "OtelId_Id");
            AddForeignKey("dbo.Rezervasyonlar", "OdaId_Id", "dbo.Odalar", "Id");
            AddForeignKey("dbo.Rezervasyonlar", "MusteriId_Id", "dbo.Musteriler", "Id");
            AddForeignKey("dbo.Otel Resimleri", "OtelId_Id", "dbo.Oteller", "Id");
            AddForeignKey("dbo.Otel Özellikleri", "OzellikId_Id", "dbo.Ozellikler", "Id");
            AddForeignKey("dbo.Otel Özellikleri", "OtelId_Id", "dbo.Oteller", "Id");
        }
    }
}
