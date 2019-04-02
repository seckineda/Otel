namespace Otel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tabloladadegisiklikyapildi2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Ilces", newName: "İlçeler");
            RenameTable(name: "dbo.Mahalles", newName: "Mahalleler");
            RenameTable(name: "dbo.Ils", newName: "İller");
            RenameTable(name: "dbo.Musteris", newName: "Musteriler");
            RenameTable(name: "dbo.Odas", newName: "Odalar");
            RenameTable(name: "dbo.Otels", newName: "Oteller");
            RenameTable(name: "dbo.Yıldız", newName: "Yıldızlar");
            RenameTable(name: "dbo.Yorums", newName: "Yorumlar");
            RenameTable(name: "dbo.OtelOzelligis", newName: "Otel Özellikleri");
            RenameTable(name: "dbo.Ozelliks", newName: "Ozellikler");
            RenameTable(name: "dbo.OtelResimleris", newName: "Otel Resimleri");
            RenameTable(name: "dbo.Rezervasyons", newName: "Rezervasyonlar");
            AlterColumn("dbo.Musteriler", "TelefonNum", c => c.String(maxLength: 11));
            AlterColumn("dbo.Yorumlar", "YorumBasligi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Yorumlar", "Yorumİcerigi", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Yorumlar", "Yorumİcerigi", c => c.String());
            AlterColumn("dbo.Yorumlar", "YorumBasligi", c => c.String());
            AlterColumn("dbo.Musteriler", "TelefonNum", c => c.String());
            RenameTable(name: "dbo.Rezervasyonlar", newName: "Rezervasyons");
            RenameTable(name: "dbo.Otel Resimleri", newName: "OtelResimleris");
            RenameTable(name: "dbo.Ozellikler", newName: "Ozelliks");
            RenameTable(name: "dbo.Otel Özellikleri", newName: "OtelOzelligis");
            RenameTable(name: "dbo.Yorumlar", newName: "Yorums");
            RenameTable(name: "dbo.Yıldızlar", newName: "Yıldız");
            RenameTable(name: "dbo.Oteller", newName: "Otels");
            RenameTable(name: "dbo.Odalar", newName: "Odas");
            RenameTable(name: "dbo.Musteriler", newName: "Musteris");
            RenameTable(name: "dbo.İller", newName: "Ils");
            RenameTable(name: "dbo.Mahalleler", newName: "Mahalles");
            RenameTable(name: "dbo.İlçeler", newName: "Ilces");
        }
    }
}
