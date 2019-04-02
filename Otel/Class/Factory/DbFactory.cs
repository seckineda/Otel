using Otel.Class.CrudFacede;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.Class.Factory
{
   public  class DbFactory
    {
        private static volatile OtelContext _db = null;
        public static OtelContext Db
        {
            get
            {
                if (_db == null)
                {
                    _db = new OtelContext();
                }
                return _db;
            }
        }
        public static volatile OtelCrud<Il> _IlCrud = null;
        public static OtelCrud<Il> IlCrud
        {
            get
            {
                if (_IlCrud == null)
                {
                    _IlCrud = new OtelCrud<Il>(Db, Db.Iller);
                }
                return _IlCrud;
            }
        }
        public static volatile OtelCrud<Ilce> _IlceCrud = null;
        public static OtelCrud<Ilce> IlceCrud
        {
            get
            {
                if (_IlceCrud == null)
                {
                    _IlceCrud = new OtelCrud<Ilce>(Db, Db.Ilceler);
                }
                return _IlceCrud;
            }
        }

        public static volatile OtelCrud<Mahalle> _mahalleCrud = null;
        public static OtelCrud<Mahalle> MahalleCrud
        {
            get
            {
                if (_mahalleCrud == null)
                {
                    _mahalleCrud = new OtelCrud<Mahalle>(Db, Db.Mahalleler);
                }
                return _mahalleCrud;
            }
        }
        public static volatile OtelCrud<Musteri> _MusteriCrud = null;
        public static OtelCrud<Musteri> MusteriCrud
        {
            get
            {
                if (_MusteriCrud == null)
                {
                    _MusteriCrud = new OtelCrud<Musteri>(Db, Db.Musteriler);
                }
                return _MusteriCrud;
            }
        }

        public static volatile OtelCrud<Oda> _OdaCrud = null;
        public static OtelCrud<Oda> OdaCrud
        {
            get
            {
                if (_OdaCrud == null)
                {
                    _OdaCrud = new OtelCrud<Oda>(Db, Db.Odalar);
                }
                return _OdaCrud;
            }
        }

        public static volatile OtelCrud<Otel> _OtelCrud = null;
        public static OtelCrud<Otel> OtelCrud
        {
            get
            {
                if (_OtelCrud == null)
                {
                    _OtelCrud = new OtelCrud<Otel>(Db, Db.Oteller);
                }
                return _OtelCrud;
            }
        }
        public static volatile OtelCrud<OtelOzelligi> _OtelOzelligiCrud = null;
        public static OtelCrud<OtelOzelligi> OtelOzelligiCrud
        {
            get
            {
                if (_OtelOzelligiCrud == null)
                {
                    _OtelOzelligiCrud = new OtelCrud<OtelOzelligi>(Db, Db.OtelOzellikler);
                }
                return _OtelOzelligiCrud;
            }
        }

        public static volatile OtelCrud<OtelResimleri> _OtelResimleriCrud = null;
        public static OtelCrud<OtelResimleri> OtelResimleriCrud
        {
            get
            {
                if (_OtelResimleriCrud == null)
                {
                    _OtelResimleriCrud = new OtelCrud<OtelResimleri>(Db, Db.OtelResimleri);
                }
                return _OtelResimleriCrud;
            }
        }

        public static volatile OtelCrud<Ozellik> _OzellikCrud = null;
        public static OtelCrud<Ozellik> OzellikCrudCrud
        {
            get
            {
                if (_OzellikCrud == null)
                {
                    _OzellikCrud = new OtelCrud<Ozellik>(Db, Db.Ozellikler);
                }
                return _OzellikCrud;
            }
        }

        public static volatile OtelCrud<Rezervasyon> _RezervasyonCrud = null;
        public static OtelCrud<Rezervasyon> RezervasyonCrud
        {
            get
            {
                if (_RezervasyonCrud == null)
                {
                    _RezervasyonCrud = new OtelCrud<Rezervasyon>(Db, Db.Rezervasyonlar);
                }
                return _RezervasyonCrud;
            }
        }

        public static volatile OtelCrud<Yıldız> _YıldızCrud = null;
        public static OtelCrud<Yıldız> YıldızCrud
        {
            get
            {
                if (_YıldızCrud == null)
                {
                    _YıldızCrud = new OtelCrud<Yıldız>(Db, Db.Yıldızlar);
                }
                return _YıldızCrud;
            }
        }

        public static volatile OtelCrud<Yorum> _YorumCrud = null;
        public static OtelCrud<Yorum> YorumCrud
        {
            get
            {
                if (_YorumCrud == null)
                {
                    _YorumCrud = new OtelCrud<Yorum>(Db, Db.Yorumlar);
                }
                return _YorumCrud;
            }
        }


    }
}
