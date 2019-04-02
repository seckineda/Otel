namespace Otel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tabloladadegisiklikyapildi5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.İlçeler", "OlusturmaTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Mahalleler", "OlusturmaTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.İller", "OlusturmaTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Musteriler", "OlusturmaTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Odalar", "OlusturmaTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Oteller", "OlusturmaTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Yıldızlar", "OlusturmaTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Yorumlar", "OlusturmaTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Otel Özellikleri", "OlusturmaTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Ozellikler", "OlusturmaTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Otel Resimleri", "OlusturmaTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rezervasyonlar", "OlusturmaTarihi", c => c.DateTime(nullable: false));
            DropColumn("dbo.İlçeler", "OlusturmatTarihi");
            DropColumn("dbo.Mahalleler", "OlusturmatTarihi");
            DropColumn("dbo.İller", "OlusturmatTarihi");
            DropColumn("dbo.Musteriler", "OlusturmatTarihi");
            DropColumn("dbo.Odalar", "OlusturmatTarihi");
            DropColumn("dbo.Oteller", "OlusturmatTarihi");
            DropColumn("dbo.Yıldızlar", "OlusturmatTarihi");
            DropColumn("dbo.Yorumlar", "OlusturmatTarihi");
            DropColumn("dbo.Otel Özellikleri", "OlusturmatTarihi");
            DropColumn("dbo.Ozellikler", "OlusturmatTarihi");
            DropColumn("dbo.Otel Resimleri", "OlusturmatTarihi");
            DropColumn("dbo.Rezervasyonlar", "OlusturmatTarihi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rezervasyonlar", "OlusturmatTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Otel Resimleri", "OlusturmatTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Ozellikler", "OlusturmatTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Otel Özellikleri", "OlusturmatTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Yorumlar", "OlusturmatTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Yıldızlar", "OlusturmatTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Oteller", "OlusturmatTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Odalar", "OlusturmatTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Musteriler", "OlusturmatTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.İller", "OlusturmatTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Mahalleler", "OlusturmatTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.İlçeler", "OlusturmatTarihi", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rezervasyonlar", "OlusturmaTarihi");
            DropColumn("dbo.Otel Resimleri", "OlusturmaTarihi");
            DropColumn("dbo.Ozellikler", "OlusturmaTarihi");
            DropColumn("dbo.Otel Özellikleri", "OlusturmaTarihi");
            DropColumn("dbo.Yorumlar", "OlusturmaTarihi");
            DropColumn("dbo.Yıldızlar", "OlusturmaTarihi");
            DropColumn("dbo.Oteller", "OlusturmaTarihi");
            DropColumn("dbo.Odalar", "OlusturmaTarihi");
            DropColumn("dbo.Musteriler", "OlusturmaTarihi");
            DropColumn("dbo.İller", "OlusturmaTarihi");
            DropColumn("dbo.Mahalleler", "OlusturmaTarihi");
            DropColumn("dbo.İlçeler", "OlusturmaTarihi");
        }
    }
}
