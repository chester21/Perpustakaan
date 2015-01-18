using System;

namespace SoFTLibrary.Framework.ComponentModels.DataModel
{
    public class BarangModel
    {
        public int KdBarang { get; set; }
        public string NmBarang      {get; set; }
        public int JenisBarang { get; set; }
        public decimal Harga { get; set; }
        public int Stock { get; set; }
        public int StatusBarang { get; set; }
        public string CreatedBy     {get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

    }

    public class AllMstLocationModel
    {
        private string _locationid;
        private string _locationName;
        private string _description;
        private string _imageName;
        private string _activeFlag;
        private string _createdDate;
        private string _createdBy;
        private string _lastUpdDate;
        private string _lastUpdBy;
        private string _img2;
        private string _mpage;


        public string Locationid
        {
            get { return _locationid; }
            set { _locationid = value; }
        }

        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string ImageName
        {
            get { return _imageName; }
            set { _imageName = value; }
        }

        public string ActiveFlag
        {
            get { return _activeFlag; }
            set { _activeFlag = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string Img2
        {
            get { return _img2; }
            set { _img2 = value; }
        }

        public string Mpage
        {
            get { return _mpage; }
            set { _mpage = value; }
        }


    }

    public class AllMstWorkFormModel
    {
        private string _typeid;
        private string _ledid;
        private string _dirid;
        private string _codeid;
        private string _descr;
        private string _recStat;
        private string _kdModul;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Typeid
        {
            get { return _typeid; }
            set { _typeid = value; }
        }

        public string Ledid
        {
            get { return _ledid; }
            set { _ledid = value; }
        }

        public string Dirid
        {
            get { return _dirid; }
            set { _dirid = value; }
        }

        public string Codeid
        {
            get { return _codeid; }
            set { _codeid = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string RecStat
        {
            get { return _recStat; }
            set { _recStat = value; }
        }

        public string KdModul
        {
            get { return _kdModul; }
            set { _kdModul = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class AllMstWorkFormDtlModel
    {
        private string _typeid;
        private string _sortid;
        private string _tagid;
        private string _indicator1;
        private string _indicator2;
        private string _showynxx;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _showyn;


        public string Typeid
        {
            get { return _typeid; }
            set { _typeid = value; }
        }

        public string Sortid
        {
            get { return _sortid; }
            set { _sortid = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Indicator1
        {
            get { return _indicator1; }
            set { _indicator1 = value; }
        }

        public string Indicator2
        {
            get { return _indicator2; }
            set { _indicator2 = value; }
        }

        public string Showynxx
        {
            get { return _showynxx; }
            set { _showynxx = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string Showyn
        {
            get { return _showyn; }
            set { _showyn = value; }
        }


    }

    public class AllMstWorkFormDtl2Model
    {
        private string _typeid;
        private string _kdDtl;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Typeid
        {
            get { return _typeid; }
            set { _typeid = value; }
        }

        public string KdDtl
        {
            get { return _kdDtl; }
            set { _kdDtl = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class AllRefBlnModel
    {
        private int _blnid;
        private string _blnnama;


        public int Blnid
        {
            get { return _blnid; }
            set { _blnid = value; }
        }

        public string Blnnama
        {
            get { return _blnnama; }
            set { _blnnama = value; }
        }


    }

    public class AllRefDirModel
    {
        private string _dirid;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _kdModul;


        public string Dirid
        {
            get { return _dirid; }
            set { _dirid = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string KdModul
        {
            get { return _kdModul; }
            set { _kdModul = value; }
        }


    }

    public class AllRefDirDtlModel
    {
        private string _dirid;
        private string _pos1;
        private string _pos2;
        private string _length12;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Dirid
        {
            get { return _dirid; }
            set { _dirid = value; }
        }

        public string Pos1
        {
            get { return _pos1; }
            set { _pos1 = value; }
        }

        public string Pos2
        {
            get { return _pos2; }
            set { _pos2 = value; }
        }

        public string Length12
        {
            get { return _length12; }
            set { _length12 = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class AllRefDirSubdtlModel
    {
        private string _dirid;
        private string _transid;
        private string _pos1;
        private string _pos2;
        private string _dataref;
        private string _defaultyn;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Dirid
        {
            get { return _dirid; }
            set { _dirid = value; }
        }

        public string Transid
        {
            get { return _transid; }
            set { _transid = value; }
        }

        public string Pos1
        {
            get { return _pos1; }
            set { _pos1 = value; }
        }

        public string Pos2
        {
            get { return _pos2; }
            set { _pos2 = value; }
        }

        public string Dataref
        {
            get { return _dataref; }
            set { _dataref = value; }
        }

        public string Defaultyn
        {
            get { return _defaultyn; }
            set { _defaultyn = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class AllRefLedModel
    {
        private string _ledid;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _kdModul;


        public string Ledid
        {
            get { return _ledid; }
            set { _ledid = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string KdModul
        {
            get { return _kdModul; }
            set { _kdModul = value; }
        }


    }

    public class AllRefLedDtlModel
    {
        private string _ledid;
        private string _pos1;
        private string _pos2;
        private string _length12;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Ledid
        {
            get { return _ledid; }
            set { _ledid = value; }
        }

        public string Pos1
        {
            get { return _pos1; }
            set { _pos1 = value; }
        }

        public string Pos2
        {
            get { return _pos2; }
            set { _pos2 = value; }
        }

        public string Length12
        {
            get { return _length12; }
            set { _length12 = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class AllRefLedSubdtlModel
    {
        private string _ledid;
        private string _pos1;
        private string _pos2;
        private string _transid;
        private string _defaultynxx;
        private string _dataref;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _defaultyn;


        public string Ledid
        {
            get { return _ledid; }
            set { _ledid = value; }
        }

        public string Pos1
        {
            get { return _pos1; }
            set { _pos1 = value; }
        }

        public string Pos2
        {
            get { return _pos2; }
            set { _pos2 = value; }
        }

        public string Transid
        {
            get { return _transid; }
            set { _transid = value; }
        }

        public string Defaultynxx
        {
            get { return _defaultynxx; }
            set { _defaultynxx = value; }
        }

        public string Dataref
        {
            get { return _dataref; }
            set { _dataref = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string Defaultyn
        {
            get { return _defaultyn; }
            set { _defaultyn = value; }
        }


    }

    public class AllSetupAppKatModel
    {
        private string _codeid;
        private string _descr;
        private string _defaultynxx;
        private string _nullValue;
        private string _indicatorSf;
        private string _endRuas;
        private string _panjang008;
        private string _endRec;
        private string _kdModul;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _defaultyn;


        public string Codeid
        {
            get { return _codeid; }
            set { _codeid = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string Defaultynxx
        {
            get { return _defaultynxx; }
            set { _defaultynxx = value; }
        }

        public string NullValue
        {
            get { return _nullValue; }
            set { _nullValue = value; }
        }

        public string IndicatorSf
        {
            get { return _indicatorSf; }
            set { _indicatorSf = value; }
        }

        public string EndRuas
        {
            get { return _endRuas; }
            set { _endRuas = value; }
        }

        public string Panjang008
        {
            get { return _panjang008; }
            set { _panjang008 = value; }
        }

        public string EndRec
        {
            get { return _endRec; }
            set { _endRec = value; }
        }

        public string KdModul
        {
            get { return _kdModul; }
            set { _kdModul = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string Defaultyn
        {
            get { return _defaultyn; }
            set { _defaultyn = value; }
        }


    }

    public class BibDataLaporanModel
    {
        private string _controlnum;
        private string _author;
        private string _title;
        private string _publisher;
        private string _tahunTerbt;
        private string _callNumber;
        private string _noInduk;
        private string _nomorItem;
        private string _noDeposit;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public string TahunTerbt
        {
            get { return _tahunTerbt; }
            set { _tahunTerbt = value; }
        }

        public string CallNumber
        {
            get { return _callNumber; }
            set { _callNumber = value; }
        }

        public string NoInduk
        {
            get { return _noInduk; }
            set { _noInduk = value; }
        }

        public string NomorItem
        {
            get { return _nomorItem; }
            set { _nomorItem = value; }
        }

        public string NoDeposit
        {
            get { return _noDeposit; }
            set { _noDeposit = value; }
        }


    }

    public class BibIndomarcrecModel
    {
        private string _controlnum;
        private string _transrec;
        private string _typeid;
        private string _bibLevel;
        private string _directoryid;
        private string _tagid;
        private string _indicator1;
        private string _indicator2;
        private string _dataItem;
        private string _dataRef;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string Typeid
        {
            get { return _typeid; }
            set { _typeid = value; }
        }

        public string BibLevel
        {
            get { return _bibLevel; }
            set { _bibLevel = value; }
        }

        public string Directoryid
        {
            get { return _directoryid; }
            set { _directoryid = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Indicator1
        {
            get { return _indicator1; }
            set { _indicator1 = value; }
        }

        public string Indicator2
        {
            get { return _indicator2; }
            set { _indicator2 = value; }
        }

        public string DataItem
        {
            get { return _dataItem; }
            set { _dataItem = value; }
        }

        public string DataRef
        {
            get { return _dataRef; }
            set { _dataRef = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibIndomarcrecDataModel
    {
        private string _controlnum;
        private string _transrec;
        private string _typeid;
        private string _bibLevel;
        private string _directoryid;
        private string _tagid;
        private string _indicator1;
        private string _indicator2;
        private string _dataItem;
        private string _dataRef;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string Typeid
        {
            get { return _typeid; }
            set { _typeid = value; }
        }

        public string BibLevel
        {
            get { return _bibLevel; }
            set { _bibLevel = value; }
        }

        public string Directoryid
        {
            get { return _directoryid; }
            set { _directoryid = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Indicator1
        {
            get { return _indicator1; }
            set { _indicator1 = value; }
        }

        public string Indicator2
        {
            get { return _indicator2; }
            set { _indicator2 = value; }
        }

        public string DataItem
        {
            get { return _dataItem; }
            set { _dataItem = value; }
        }

        public string DataRef
        {
            get { return _dataRef; }
            set { _dataRef = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibIndomarcrecDataHisModel
    {
        private string _bibId;
        private string _controlnum;
        private string _typeid;
        private string _bibLevel;
        private string _createdByHis;
        private string _createdDateHis;
        private string _lastUpdByHis;
        private string _lastUpdDateHis;
        private string _plainText;
        private string _createdBy;
        private string _createdDate;


        public string BibId
        {
            get { return _bibId; }
            set { _bibId = value; }
        }

        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Typeid
        {
            get { return _typeid; }
            set { _typeid = value; }
        }

        public string BibLevel
        {
            get { return _bibLevel; }
            set { _bibLevel = value; }
        }

        public string CreatedByHis
        {
            get { return _createdByHis; }
            set { _createdByHis = value; }
        }

        public string CreatedDateHis
        {
            get { return _createdDateHis; }
            set { _createdDateHis = value; }
        }

        public string LastUpdByHis
        {
            get { return _lastUpdByHis; }
            set { _lastUpdByHis = value; }
        }

        public string LastUpdDateHis
        {
            get { return _lastUpdDateHis; }
            set { _lastUpdDateHis = value; }
        }

        public string PlainText
        {
            get { return _plainText; }
            set { _plainText = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }


    }

    public class BibIndomarcrecDataMigrationModel
    {
        private string _controlnum;
        private string _transrec;
        private string _typeid;
        private string _bibLevel;
        private string _directoryid;
        private string _tagid;
        private string _indicator1;
        private string _indicator2;
        private string _dataItem;
        private string _dataRef;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _action;
        private string _migrated;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string Typeid
        {
            get { return _typeid; }
            set { _typeid = value; }
        }

        public string BibLevel
        {
            get { return _bibLevel; }
            set { _bibLevel = value; }
        }

        public string Directoryid
        {
            get { return _directoryid; }
            set { _directoryid = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Indicator1
        {
            get { return _indicator1; }
            set { _indicator1 = value; }
        }

        public string Indicator2
        {
            get { return _indicator2; }
            set { _indicator2 = value; }
        }

        public string DataItem
        {
            get { return _dataItem; }
            set { _dataItem = value; }
        }

        public string DataRef
        {
            get { return _dataRef; }
            set { _dataRef = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }

        public string Migrated
        {
            get { return _migrated; }
            set { _migrated = value; }
        }


    }

    public class BibIndomarcrecData1Model
    {
        private string _controlnum;
        private string _transrec;
        private string _typeid;
        private string _bibLevel;
        private string _directoryid;
        private string _tagid;
        private string _indicator1;
        private string _indicator2;
        private string _dataItem;
        private string _dataRef;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string Typeid
        {
            get { return _typeid; }
            set { _typeid = value; }
        }

        public string BibLevel
        {
            get { return _bibLevel; }
            set { _bibLevel = value; }
        }

        public string Directoryid
        {
            get { return _directoryid; }
            set { _directoryid = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Indicator1
        {
            get { return _indicator1; }
            set { _indicator1 = value; }
        }

        public string Indicator2
        {
            get { return _indicator2; }
            set { _indicator2 = value; }
        }

        public string DataItem
        {
            get { return _dataItem; }
            set { _dataItem = value; }
        }

        public string DataRef
        {
            get { return _dataRef; }
            set { _dataRef = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibIndomarcrecFileModel
    {
        private string _controlnum;
        private string _transrec;
        private string _type;
        private string _fileName;
        private string _fileSize;
        private string _fileCaption;
        private string _fileTooltip;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        public string FileSize
        {
            get { return _fileSize; }
            set { _fileSize = value; }
        }

        public string FileCaption
        {
            get { return _fileCaption; }
            set { _fileCaption = value; }
        }

        public string FileTooltip
        {
            get { return _fileTooltip; }
            set { _fileTooltip = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibIndomarcrecFile1Model
    {
        private string _controlnum;
        private string _transrec;
        private string _type;
        private string _fileName;
        private string _fileSize;
        private string _fileCaption;
        private string _fileTooltip;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        public string FileSize
        {
            get { return _fileSize; }
            set { _fileSize = value; }
        }

        public string FileCaption
        {
            get { return _fileCaption; }
            set { _fileCaption = value; }
        }

        public string FileTooltip
        {
            get { return _fileTooltip; }
            set { _fileTooltip = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstBahasaModel
    {
        private string _codeid;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Codeid
        {
            get { return _codeid; }
            set { _codeid = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstIndicator1Model
    {
        private string _kdModul;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string KdModul
        {
            get { return _kdModul; }
            set { _kdModul = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstIndicator1DtlModel
    {
        private string _kdModul;
        private string _tagid;
        private string _indicator1;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string KdModul
        {
            get { return _kdModul; }
            set { _kdModul = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Indicator1
        {
            get { return _indicator1; }
            set { _indicator1 = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstIndicator2Model
    {
        private string _kdModul;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string KdModul
        {
            get { return _kdModul; }
            set { _kdModul = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstIndicator2DtlModel
    {
        private string _kdModul;
        private string _tagid;
        private string _indicator2;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string KdModul
        {
            get { return _kdModul; }
            set { _kdModul = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Indicator2
        {
            get { return _indicator2; }
            set { _indicator2 = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstIntervalPelanggaranModel
    {
        private string _codeid;
        private string _descr;
        private int _value;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Codeid
        {
            get { return _codeid; }
            set { _codeid = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstItemClassModel
    {
        private string _classid;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Classid
        {
            get { return _classid; }
            set { _classid = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstItemStatusModel
    {
        private string _statusid;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Statusid
        {
            get { return _statusid; }
            set { _statusid = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstKatalogModel
    {
        private string _controlnum;
        private string _bibId;
        private string _bibLevel;
        private string _typeid;
        private string _author;
        private string _title;
        private string _publisher;
        private string _tahunTerbit;
        private string _callNumber;
        private string _quantity;
        private string _checkedOut;
        private string _onReserve;
        private string _available;
        private string _requested;
        private string _onHold;
        private string _other;
        private string _copy;
        private string _areaCode;
        private string _validateOpac;
        private string _validateOpacDate;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _subject;
        private string _printkin;
        private string _printbni;
        private string _detailBp;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string BibId
        {
            get { return _bibId; }
            set { _bibId = value; }
        }

        public string BibLevel
        {
            get { return _bibLevel; }
            set { _bibLevel = value; }
        }

        public string Typeid
        {
            get { return _typeid; }
            set { _typeid = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public string TahunTerbit
        {
            get { return _tahunTerbit; }
            set { _tahunTerbit = value; }
        }

        public string CallNumber
        {
            get { return _callNumber; }
            set { _callNumber = value; }
        }

        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public string CheckedOut
        {
            get { return _checkedOut; }
            set { _checkedOut = value; }
        }

        public string OnReserve
        {
            get { return _onReserve; }
            set { _onReserve = value; }
        }

        public string Available
        {
            get { return _available; }
            set { _available = value; }
        }

        public string Requested
        {
            get { return _requested; }
            set { _requested = value; }
        }

        public string OnHold
        {
            get { return _onHold; }
            set { _onHold = value; }
        }

        public string Other
        {
            get { return _other; }
            set { _other = value; }
        }

        public string Copy
        {
            get { return _copy; }
            set { _copy = value; }
        }

        public string AreaCode
        {
            get { return _areaCode; }
            set { _areaCode = value; }
        }

        public string ValidateOpac
        {
            get { return _validateOpac; }
            set { _validateOpac = value; }
        }

        public string ValidateOpacDate
        {
            get { return _validateOpacDate; }
            set { _validateOpacDate = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public string Printkin
        {
            get { return _printkin; }
            set { _printkin = value; }
        }

        public string Printbni
        {
            get { return _printbni; }
            set { _printbni = value; }
        }

        public string DetailBp
        {
            get { return _detailBp; }
            set { _detailBp = value; }
        }


    }

    public class BibMstKatalogDtlModel
    {
        private string _controlnum;
        private string _nomorItem;
        private string _lokasi;
        private string _lokasiLantai;
        private string _idRak;
        private string _nomerRak;
        private string _hargaBuku;
        private string _dendaTerlambat;
        private string _jangkaPinjam;
        private string _kriteriaBuku;
        private string _jenisPinjam;
        private string _itemClass;
        private string _statusMasuk;
        private string _tanggalMasuk;
        private string _statusKeluar;
        private string _tanggalKeluar;
        private string _statusPinjam;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string NomorItem
        {
            get { return _nomorItem; }
            set { _nomorItem = value; }
        }

        public string Lokasi
        {
            get { return _lokasi; }
            set { _lokasi = value; }
        }

        public string LokasiLantai
        {
            get { return _lokasiLantai; }
            set { _lokasiLantai = value; }
        }

        public string IdRak
        {
            get { return _idRak; }
            set { _idRak = value; }
        }

        public string NomerRak
        {
            get { return _nomerRak; }
            set { _nomerRak = value; }
        }

        public string HargaBuku
        {
            get { return _hargaBuku; }
            set { _hargaBuku = value; }
        }

        public string DendaTerlambat
        {
            get { return _dendaTerlambat; }
            set { _dendaTerlambat = value; }
        }

        public string JangkaPinjam
        {
            get { return _jangkaPinjam; }
            set { _jangkaPinjam = value; }
        }

        public string KriteriaBuku
        {
            get { return _kriteriaBuku; }
            set { _kriteriaBuku = value; }
        }

        public string JenisPinjam
        {
            get { return _jenisPinjam; }
            set { _jenisPinjam = value; }
        }

        public string ItemClass
        {
            get { return _itemClass; }
            set { _itemClass = value; }
        }

        public string StatusMasuk
        {
            get { return _statusMasuk; }
            set { _statusMasuk = value; }
        }

        public string TanggalMasuk
        {
            get { return _tanggalMasuk; }
            set { _tanggalMasuk = value; }
        }

        public string StatusKeluar
        {
            get { return _statusKeluar; }
            set { _statusKeluar = value; }
        }

        public string TanggalKeluar
        {
            get { return _tanggalKeluar; }
            set { _tanggalKeluar = value; }
        }

        public string StatusPinjam
        {
            get { return _statusPinjam; }
            set { _statusPinjam = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstKatalogDtl1Model
    {
        private string _controlnum;
        private string _nomorItem;
        private string _lokasi;
        private string _lokasiLantai;
        private string _idRak;
        private string _nomerRak;
        private string _hargaBuku;
        private string _dendaTerlambat;
        private string _jangkaPinjam;
        private string _kriteriaBuku;
        private string _jenisPinjam;
        private string _itemClass;
        private string _statusMasuk;
        private string _tanggalMasuk;
        private string _statusKeluar;
        private string _tanggalKeluar;
        private string _statusPinjam;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string NomorItem
        {
            get { return _nomorItem; }
            set { _nomorItem = value; }
        }

        public string Lokasi
        {
            get { return _lokasi; }
            set { _lokasi = value; }
        }

        public string LokasiLantai
        {
            get { return _lokasiLantai; }
            set { _lokasiLantai = value; }
        }

        public string IdRak
        {
            get { return _idRak; }
            set { _idRak = value; }
        }

        public string NomerRak
        {
            get { return _nomerRak; }
            set { _nomerRak = value; }
        }

        public string HargaBuku
        {
            get { return _hargaBuku; }
            set { _hargaBuku = value; }
        }

        public string DendaTerlambat
        {
            get { return _dendaTerlambat; }
            set { _dendaTerlambat = value; }
        }

        public string JangkaPinjam
        {
            get { return _jangkaPinjam; }
            set { _jangkaPinjam = value; }
        }

        public string KriteriaBuku
        {
            get { return _kriteriaBuku; }
            set { _kriteriaBuku = value; }
        }

        public string JenisPinjam
        {
            get { return _jenisPinjam; }
            set { _jenisPinjam = value; }
        }

        public string ItemClass
        {
            get { return _itemClass; }
            set { _itemClass = value; }
        }

        public string StatusMasuk
        {
            get { return _statusMasuk; }
            set { _statusMasuk = value; }
        }

        public string TanggalMasuk
        {
            get { return _tanggalMasuk; }
            set { _tanggalMasuk = value; }
        }

        public string StatusKeluar
        {
            get { return _statusKeluar; }
            set { _statusKeluar = value; }
        }

        public string TanggalKeluar
        {
            get { return _tanggalKeluar; }
            set { _tanggalKeluar = value; }
        }

        public string StatusPinjam
        {
            get { return _statusPinjam; }
            set { _statusPinjam = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstKatalogInfoModel
    {
        private string _nomorItem;
        private string _statusBuku;
        private string _keterangan;
        private string _createdBy;
        private string _createdDate;
        private string _updatedBy;
        private string _updatedDate;


        public string NomorItem
        {
            get { return _nomorItem; }
            set { _nomorItem = value; }
        }

        public string StatusBuku
        {
            get { return _statusBuku; }
            set { _statusBuku = value; }
        }

        public string Keterangan
        {
            get { return _keterangan; }
            set { _keterangan = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }

        public string UpdatedDate
        {
            get { return _updatedDate; }
            set { _updatedDate = value; }
        }


    }

    public class BibMstKatalog1Model
    {
        private string _controlnum;
        private string _bibId;
        private string _bibLevel;
        private string _typeid;
        private string _author;
        private string _title;
        private string _publisher;
        private string _tahunTerbit;
        private string _callNumber;
        private string _quantity;
        private string _checkedOut;
        private string _onReserve;
        private string _available;
        private string _requested;
        private string _onHold;
        private string _other;
        private string _copy;
        private string _areaCode;
        private string _validateOpac;
        private string _validateOpacDate;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _subject;
        private string _printkin;
        private string _printbni;
        private string _detailBp;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string BibId
        {
            get { return _bibId; }
            set { _bibId = value; }
        }

        public string BibLevel
        {
            get { return _bibLevel; }
            set { _bibLevel = value; }
        }

        public string Typeid
        {
            get { return _typeid; }
            set { _typeid = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public string TahunTerbit
        {
            get { return _tahunTerbit; }
            set { _tahunTerbit = value; }
        }

        public string CallNumber
        {
            get { return _callNumber; }
            set { _callNumber = value; }
        }

        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public string CheckedOut
        {
            get { return _checkedOut; }
            set { _checkedOut = value; }
        }

        public string OnReserve
        {
            get { return _onReserve; }
            set { _onReserve = value; }
        }

        public string Available
        {
            get { return _available; }
            set { _available = value; }
        }

        public string Requested
        {
            get { return _requested; }
            set { _requested = value; }
        }

        public string OnHold
        {
            get { return _onHold; }
            set { _onHold = value; }
        }

        public string Other
        {
            get { return _other; }
            set { _other = value; }
        }

        public string Copy
        {
            get { return _copy; }
            set { _copy = value; }
        }

        public string AreaCode
        {
            get { return _areaCode; }
            set { _areaCode = value; }
        }

        public string ValidateOpac
        {
            get { return _validateOpac; }
            set { _validateOpac = value; }
        }

        public string ValidateOpacDate
        {
            get { return _validateOpacDate; }
            set { _validateOpacDate = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public string Printkin
        {
            get { return _printkin; }
            set { _printkin = value; }
        }

        public string Printbni
        {
            get { return _printbni; }
            set { _printbni = value; }
        }

        public string DetailBp
        {
            get { return _detailBp; }
            set { _detailBp = value; }
        }


    }

    public class BibMstLocationModel
    {
        private string _locationid;
        private string _name;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Locationid
        {
            get { return _locationid; }
            set { _locationid = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstNegaraModel
    {
        private string _codeid;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Codeid
        {
            get { return _codeid; }
            set { _codeid = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstSubfieldModel
    {
        private string _kdModul;
        private string _descr;
        private string _createdLoc;
        private string _updatedLoc;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string KdModul
        {
            get { return _kdModul; }
            set { _kdModul = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedLoc
        {
            get { return _createdLoc; }
            set { _createdLoc = value; }
        }

        public string UpdatedLoc
        {
            get { return _updatedLoc; }
            set { _updatedLoc = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstSubfieldDtlModel
    {
        private string _kdModul;
        private string _tagid;
        private string _subfield;
        private string _descr;
        private string _repeatynxx;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _repeatyn;


        public string KdModul
        {
            get { return _kdModul; }
            set { _kdModul = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Subfield
        {
            get { return _subfield; }
            set { _subfield = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string Repeatynxx
        {
            get { return _repeatynxx; }
            set { _repeatynxx = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string Repeatyn
        {
            get { return _repeatyn; }
            set { _repeatyn = value; }
        }


    }

    public class BibMstTagModel
    {
        private string _kdModul;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string KdModul
        {
            get { return _kdModul; }
            set { _kdModul = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibMstTagDtlModel
    {
        private string _kdModul;
        private string _tagid;
        private string _showynxx;
        private string _mainentryynxx;
        private string _repeatynxx;
        private string _requeredynxx;
        private string _publicynxx;
        private string _showsfynxx;
        private string _descr;
        private string _otorisasi;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _mainentryyn;
        private string _repeatyn;
        private string _requeredyn;
        private string _publicyn;
        private string _showsfyn;
        private string _showyn;


        public string KdModul
        {
            get { return _kdModul; }
            set { _kdModul = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Showynxx
        {
            get { return _showynxx; }
            set { _showynxx = value; }
        }

        public string Mainentryynxx
        {
            get { return _mainentryynxx; }
            set { _mainentryynxx = value; }
        }

        public string Repeatynxx
        {
            get { return _repeatynxx; }
            set { _repeatynxx = value; }
        }

        public string Requeredynxx
        {
            get { return _requeredynxx; }
            set { _requeredynxx = value; }
        }

        public string Publicynxx
        {
            get { return _publicynxx; }
            set { _publicynxx = value; }
        }

        public string Showsfynxx
        {
            get { return _showsfynxx; }
            set { _showsfynxx = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string Otorisasi
        {
            get { return _otorisasi; }
            set { _otorisasi = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string Mainentryyn
        {
            get { return _mainentryyn; }
            set { _mainentryyn = value; }
        }

        public string Repeatyn
        {
            get { return _repeatyn; }
            set { _repeatyn = value; }
        }

        public string Requeredyn
        {
            get { return _requeredyn; }
            set { _requeredyn = value; }
        }

        public string Publicyn
        {
            get { return _publicyn; }
            set { _publicyn = value; }
        }

        public string Showsfyn
        {
            get { return _showsfyn; }
            set { _showsfyn = value; }
        }

        public string Showyn
        {
            get { return _showyn; }
            set { _showyn = value; }
        }


    }

    public class BibRef008Model
    {
        private string _oo8id;
        private string _oo7id;
        private string _oo6id;
        private string _kdInit;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Oo8id
        {
            get { return _oo8id; }
            set { _oo8id = value; }
        }

        public string Oo7id
        {
            get { return _oo7id; }
            set { _oo7id = value; }
        }

        public string Oo6id
        {
            get { return _oo6id; }
            set { _oo6id = value; }
        }

        public string KdInit
        {
            get { return _kdInit; }
            set { _kdInit = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibRef008DtlModel
    {
        private string _oo8id;
        private string _pos1;
        private string _pos2;
        private string _length12;
        private string _displtop;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Oo8id
        {
            get { return _oo8id; }
            set { _oo8id = value; }
        }

        public string Pos1
        {
            get { return _pos1; }
            set { _pos1 = value; }
        }

        public string Pos2
        {
            get { return _pos2; }
            set { _pos2 = value; }
        }

        public string Length12
        {
            get { return _length12; }
            set { _length12 = value; }
        }

        public string Displtop
        {
            get { return _displtop; }
            set { _displtop = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class BibRef008SubdtlModel
    {
        private string _oo8id;
        private string _pos1;
        private string _pos2;
        private string _transid;
        private string _dataref;
        private string _oo7ynxx;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _oo7yn;


        public string Oo8id
        {
            get { return _oo8id; }
            set { _oo8id = value; }
        }

        public string Pos1
        {
            get { return _pos1; }
            set { _pos1 = value; }
        }

        public string Pos2
        {
            get { return _pos2; }
            set { _pos2 = value; }
        }

        public string Transid
        {
            get { return _transid; }
            set { _transid = value; }
        }

        public string Dataref
        {
            get { return _dataref; }
            set { _dataref = value; }
        }

        public string Oo7ynxx
        {
            get { return _oo7ynxx; }
            set { _oo7ynxx = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string Oo7yn
        {
            get { return _oo7yn; }
            set { _oo7yn = value; }
        }


    }

    public class BibSearchAuthorModel
    {
        private string _controlnum;
        private string _transrec;
        private string _tagid;
        private string _indicator1;
        private string _indicator2;
        private string _dataItem;
        private string _dataDisplay;
        private string _dataSearch;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Indicator1
        {
            get { return _indicator1; }
            set { _indicator1 = value; }
        }

        public string Indicator2
        {
            get { return _indicator2; }
            set { _indicator2 = value; }
        }

        public string DataItem
        {
            get { return _dataItem; }
            set { _dataItem = value; }
        }

        public string DataDisplay
        {
            get { return _dataDisplay; }
            set { _dataDisplay = value; }
        }

        public string DataSearch
        {
            get { return _dataSearch; }
            set { _dataSearch = value; }
        }


    }

    public class BibSearchAuthor1Model
    {
        private string _controlnum;
        private string _transrec;
        private string _tagid;
        private string _indicator1;
        private string _indicator2;
        private string _dataItem;
        private string _dataDisplay;
        private string _dataSearch;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Indicator1
        {
            get { return _indicator1; }
            set { _indicator1 = value; }
        }

        public string Indicator2
        {
            get { return _indicator2; }
            set { _indicator2 = value; }
        }

        public string DataItem
        {
            get { return _dataItem; }
            set { _dataItem = value; }
        }

        public string DataDisplay
        {
            get { return _dataDisplay; }
            set { _dataDisplay = value; }
        }

        public string DataSearch
        {
            get { return _dataSearch; }
            set { _dataSearch = value; }
        }


    }

    public class BibSearchSubjectModel
    {
        private string _controlnum;
        private string _transrec;
        private string _tagid;
        private string _indicator1;
        private string _indicator2;
        private string _dataItem;
        private string _dataDisplay;
        private string _dataSearch;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Indicator1
        {
            get { return _indicator1; }
            set { _indicator1 = value; }
        }

        public string Indicator2
        {
            get { return _indicator2; }
            set { _indicator2 = value; }
        }

        public string DataItem
        {
            get { return _dataItem; }
            set { _dataItem = value; }
        }

        public string DataDisplay
        {
            get { return _dataDisplay; }
            set { _dataDisplay = value; }
        }

        public string DataSearch
        {
            get { return _dataSearch; }
            set { _dataSearch = value; }
        }


    }

    public class BibSearchSubject1Model
    {
        private string _controlnum;
        private string _transrec;
        private string _tagid;
        private string _indicator1;
        private string _indicator2;
        private string _dataItem;
        private string _dataDisplay;
        private string _dataSearch;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Indicator1
        {
            get { return _indicator1; }
            set { _indicator1 = value; }
        }

        public string Indicator2
        {
            get { return _indicator2; }
            set { _indicator2 = value; }
        }

        public string DataItem
        {
            get { return _dataItem; }
            set { _dataItem = value; }
        }

        public string DataDisplay
        {
            get { return _dataDisplay; }
            set { _dataDisplay = value; }
        }

        public string DataSearch
        {
            get { return _dataSearch; }
            set { _dataSearch = value; }
        }


    }

    public class BibSearchTitleModel
    {
        private string _controlnum;
        private string _transrec;
        private string _tagid;
        private string _indicator1;
        private string _indicator2;
        private string _dataItem;
        private string _dataDisplay;
        private string _dataSearch;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Indicator1
        {
            get { return _indicator1; }
            set { _indicator1 = value; }
        }

        public string Indicator2
        {
            get { return _indicator2; }
            set { _indicator2 = value; }
        }

        public string DataItem
        {
            get { return _dataItem; }
            set { _dataItem = value; }
        }

        public string DataDisplay
        {
            get { return _dataDisplay; }
            set { _dataDisplay = value; }
        }

        public string DataSearch
        {
            get { return _dataSearch; }
            set { _dataSearch = value; }
        }


    }

    public class BibSearchTitle1Model
    {
        private string _controlnum;
        private string _transrec;
        private string _tagid;
        private string _indicator1;
        private string _indicator2;
        private string _dataItem;
        private string _dataDisplay;
        private string _dataSearch;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }

        public string Indicator1
        {
            get { return _indicator1; }
            set { _indicator1 = value; }
        }

        public string Indicator2
        {
            get { return _indicator2; }
            set { _indicator2 = value; }
        }

        public string DataItem
        {
            get { return _dataItem; }
            set { _dataItem = value; }
        }

        public string DataDisplay
        {
            get { return _dataDisplay; }
            set { _dataDisplay = value; }
        }

        public string DataSearch
        {
            get { return _dataSearch; }
            set { _dataSearch = value; }
        }


    }

    public class CpRegisteredModel
    {
        private string _nomorAnggota;
        private string _dateRegister;


        public string NomorAnggota
        {
            get { return _nomorAnggota; }
            set { _nomorAnggota = value; }
        }

        public string DateRegister
        {
            get { return _dateRegister; }
            set { _dateRegister = value; }
        }


    }

    public class CpUnregisteredModel
    {
        private string _nama;
        private string _jenisKelamin;
        private string _pekerjaan;
        private string _telp;
        private string _dateRegister;


        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string JenisKelamin
        {
            get { return _jenisKelamin; }
            set { _jenisKelamin = value; }
        }

        public string Pekerjaan
        {
            get { return _pekerjaan; }
            set { _pekerjaan = value; }
        }

        public string Telp
        {
            get { return _telp; }
            set { _telp = value; }
        }

        public string DateRegister
        {
            get { return _dateRegister; }
            set { _dateRegister = value; }
        }


    }

    public class FileBmpModel
    {
        private string _namaFile;
        private string _fileRecord;


        public string NamaFile
        {
            get { return _namaFile; }
            set { _namaFile = value; }
        }

        public string FileRecord
        {
            get { return _fileRecord; }
            set { _fileRecord = value; }
        }


    }

    public class GeneralReferenceModel
    {
        private string _refFile;
        private string _refDesc;
        private string _recStat;
        private string _statAdmin;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string RefFile
        {
            get { return _refFile; }
            set { _refFile = value; }
        }

        public string RefDesc
        {
            get { return _refDesc; }
            set { _refDesc = value; }
        }

        public string RecStat
        {
            get { return _recStat; }
            set { _recStat = value; }
        }

        public string StatAdmin
        {
            get { return _statAdmin; }
            set { _statAdmin = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class GeneralReferenceDtlModel
    {
        private string _refFile;
        private string _refFileDtl;
        private string _refdtlValue1;
        private string _refdtlValue2;
        private string _refdtlDesc;
        private string _recStat;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string RefFile
        {
            get { return _refFile; }
            set { _refFile = value; }
        }

        public string RefFileDtl
        {
            get { return _refFileDtl; }
            set { _refFileDtl = value; }
        }

        public string RefdtlValue1
        {
            get { return _refdtlValue1; }
            set { _refdtlValue1 = value; }
        }

        public string RefdtlValue2
        {
            get { return _refdtlValue2; }
            set { _refdtlValue2 = value; }
        }

        public string RefdtlDesc
        {
            get { return _refdtlDesc; }
            set { _refdtlDesc = value; }
        }

        public string RecStat
        {
            get { return _recStat; }
            set { _recStat = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class ListPerpustakaanModel
    {
        private string _namaPerpus;
        private string _linkSite;
        private string _keterangan;
        private int _jmlBuku;
        private string _idPerpus;


        public string NamaPerpus
        {
            get { return _namaPerpus; }
            set { _namaPerpus = value; }
        }

        public string LinkSite
        {
            get { return _linkSite; }
            set { _linkSite = value; }
        }

        public string Keterangan
        {
            get { return _keterangan; }
            set { _keterangan = value; }
        }

        public int JmlBuku
        {
            get { return _jmlBuku; }
            set { _jmlBuku = value; }
        }

        public string IdPerpus
        {
            get { return _idPerpus; }
            set { _idPerpus = value; }
        }


    }

    public class MstSetupAplikasiModel
    {
        private string _kode;
        private string _logo;
        private string _path;
        private string _aktiv;
        private string _labeltext;


        public string Kode
        {
            get { return _kode; }
            set { _kode = value; }
        }

        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public string Aktiv
        {
            get { return _aktiv; }
            set { _aktiv = value; }
        }

        public string Labeltext
        {
            get { return _labeltext; }
            set { _labeltext = value; }
        }


    }

    public class OpacCartModel
    {
        private string _sessionid;
        private string _controlnum;
        private string _createdDate;


        public string Sessionid
        {
            get { return _sessionid; }
            set { _sessionid = value; }
        }

        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }


    }

    public class OpacSettingModel
    {
        private int _key1;
        private int _key2;
        private string _name1;
        private string _name2;
        private string _value;
        private string _keterangan;
        private string _activated;


        public int Key1
        {
            get { return _key1; }
            set { _key1 = value; }
        }

        public int Key2
        {
            get { return _key2; }
            set { _key2 = value; }
        }

        public string Name1
        {
            get { return _name1; }
            set { _name1 = value; }
        }

        public string Name2
        {
            get { return _name2; }
            set { _name2 = value; }
        }

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public string Keterangan
        {
            get { return _keterangan; }
            set { _keterangan = value; }
        }

        public string Activated
        {
            get { return _activated; }
            set { _activated = value; }
        }


    }

    public class SirMstAnggotaModel
    {
        private string _angId;
        private string _angNm;
        private string _tmpLhr;
        private string _tglLhr;
        private string _noIdentitas;
        private string _almtRmh;
        private string _telpRmh;
        private string _nmInt;
        private string _almtInt;
        private string _telpInt;
        private string _tglMul;
        private string _tglAkh;
        private string _statusAng;
        private string _pendidikan;
        private string _pekerjaan;
        private string _agama;
        private string _gender;
        private string _staKawin;
        private string _jnsRegistrasi;
        private string _regStat;
        private string _noregOld;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _imageContent;
        private string _barcode;
        private string _imageName;
        private string _photo;


        public string AngId
        {
            get { return _angId; }
            set { _angId = value; }
        }

        public string AngNm
        {
            get { return _angNm; }
            set { _angNm = value; }
        }

        public string TmpLhr
        {
            get { return _tmpLhr; }
            set { _tmpLhr = value; }
        }

        public string TglLhr
        {
            get { return _tglLhr; }
            set { _tglLhr = value; }
        }

        public string NoIdentitas
        {
            get { return _noIdentitas; }
            set { _noIdentitas = value; }
        }

        public string AlmtRmh
        {
            get { return _almtRmh; }
            set { _almtRmh = value; }
        }

        public string TelpRmh
        {
            get { return _telpRmh; }
            set { _telpRmh = value; }
        }

        public string NmInt
        {
            get { return _nmInt; }
            set { _nmInt = value; }
        }

        public string AlmtInt
        {
            get { return _almtInt; }
            set { _almtInt = value; }
        }

        public string TelpInt
        {
            get { return _telpInt; }
            set { _telpInt = value; }
        }

        public string TglMul
        {
            get { return _tglMul; }
            set { _tglMul = value; }
        }

        public string TglAkh
        {
            get { return _tglAkh; }
            set { _tglAkh = value; }
        }

        public string StatusAng
        {
            get { return _statusAng; }
            set { _statusAng = value; }
        }

        public string Pendidikan
        {
            get { return _pendidikan; }
            set { _pendidikan = value; }
        }

        public string Pekerjaan
        {
            get { return _pekerjaan; }
            set { _pekerjaan = value; }
        }

        public string Agama
        {
            get { return _agama; }
            set { _agama = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string StaKawin
        {
            get { return _staKawin; }
            set { _staKawin = value; }
        }

        public string JnsRegistrasi
        {
            get { return _jnsRegistrasi; }
            set { _jnsRegistrasi = value; }
        }

        public string RegStat
        {
            get { return _regStat; }
            set { _regStat = value; }
        }

        public string NoregOld
        {
            get { return _noregOld; }
            set { _noregOld = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string ImageContent
        {
            get { return _imageContent; }
            set { _imageContent = value; }
        }

        public string Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }

        public string ImageName
        {
            get { return _imageName; }
            set { _imageName = value; }
        }

        public string Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }


    }

    public class SirMstAnggotaBayarModel
    {
        private string _angId;
        private string _tglBayar;
        private int _jmlBayar;
        private string _jnsBayar;
        private string _createdDate;
        private string _createdBy;
        private string _lastUpdDate;
        private string _lastUpdBy;
        private int _id;
        private string _stBayar;


        public string AngId
        {
            get { return _angId; }
            set { _angId = value; }
        }

        public string TglBayar
        {
            get { return _tglBayar; }
            set { _tglBayar = value; }
        }

        public int JmlBayar
        {
            get { return _jmlBayar; }
            set { _jmlBayar = value; }
        }

        public string JnsBayar
        {
            get { return _jnsBayar; }
            set { _jnsBayar = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string StBayar
        {
            get { return _stBayar; }
            set { _stBayar = value; }
        }


    }

    public class SirMstAnggotaOlModel
    {
        private string _angId;
        private string _angNm;
        private string _tmpLhr;
        private string _tglLhr;
        private string _noIdentitas;
        private string _almtRmh;
        private string _telpRmh;
        private string _nmInt;
        private string _almtInt;
        private string _telpInt;
        private string _tglMul;
        private string _tglAkh;
        private string _statusAng;
        private string _pendidikan;
        private string _pekerjaan;
        private string _agama;
        private string _gender;
        private string _staKawin;
        private string _jnsRegistrasi;
        private string _regStat;
        private string _noregOld;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _imageContent;
        private string _barcode;
        private string _imageName;
        private string _noRegistrasi;


        public string AngId
        {
            get { return _angId; }
            set { _angId = value; }
        }

        public string AngNm
        {
            get { return _angNm; }
            set { _angNm = value; }
        }

        public string TmpLhr
        {
            get { return _tmpLhr; }
            set { _tmpLhr = value; }
        }

        public string TglLhr
        {
            get { return _tglLhr; }
            set { _tglLhr = value; }
        }

        public string NoIdentitas
        {
            get { return _noIdentitas; }
            set { _noIdentitas = value; }
        }

        public string AlmtRmh
        {
            get { return _almtRmh; }
            set { _almtRmh = value; }
        }

        public string TelpRmh
        {
            get { return _telpRmh; }
            set { _telpRmh = value; }
        }

        public string NmInt
        {
            get { return _nmInt; }
            set { _nmInt = value; }
        }

        public string AlmtInt
        {
            get { return _almtInt; }
            set { _almtInt = value; }
        }

        public string TelpInt
        {
            get { return _telpInt; }
            set { _telpInt = value; }
        }

        public string TglMul
        {
            get { return _tglMul; }
            set { _tglMul = value; }
        }

        public string TglAkh
        {
            get { return _tglAkh; }
            set { _tglAkh = value; }
        }

        public string StatusAng
        {
            get { return _statusAng; }
            set { _statusAng = value; }
        }

        public string Pendidikan
        {
            get { return _pendidikan; }
            set { _pendidikan = value; }
        }

        public string Pekerjaan
        {
            get { return _pekerjaan; }
            set { _pekerjaan = value; }
        }

        public string Agama
        {
            get { return _agama; }
            set { _agama = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string StaKawin
        {
            get { return _staKawin; }
            set { _staKawin = value; }
        }

        public string JnsRegistrasi
        {
            get { return _jnsRegistrasi; }
            set { _jnsRegistrasi = value; }
        }

        public string RegStat
        {
            get { return _regStat; }
            set { _regStat = value; }
        }

        public string NoregOld
        {
            get { return _noregOld; }
            set { _noregOld = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string ImageContent
        {
            get { return _imageContent; }
            set { _imageContent = value; }
        }

        public string Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }

        public string ImageName
        {
            get { return _imageName; }
            set { _imageName = value; }
        }

        public string NoRegistrasi
        {
            get { return _noRegistrasi; }
            set { _noRegistrasi = value; }
        }


    }

    public class SirMstDendaModel
    {
        private string _codeid;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Codeid
        {
            get { return _codeid; }
            set { _codeid = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class SirMstDendaHariModel
    {
        private string _angId;
        private string _tglKembali;
        private int _lamaDenda;


        public string AngId
        {
            get { return _angId; }
            set { _angId = value; }
        }

        public string TglKembali
        {
            get { return _tglKembali; }
            set { _tglKembali = value; }
        }

        public int LamaDenda
        {
            get { return _lamaDenda; }
            set { _lamaDenda = value; }
        }


    }

    public class SirMstHariKerjaModel
    {
        private int _hariAwal;
        private string _keterangan;


        public int HariAwal
        {
            get { return _hariAwal; }
            set { _hariAwal = value; }
        }

        public string Keterangan
        {
            get { return _keterangan; }
            set { _keterangan = value; }
        }


    }

    public class SirMstJenisPelanggaranModel
    {
        private int _id;
        private string _jenisPelanggaran;
        private string _keterangan;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string JenisPelanggaran
        {
            get { return _jenisPelanggaran; }
            set { _jenisPelanggaran = value; }
        }

        public string Keterangan
        {
            get { return _keterangan; }
            set { _keterangan = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class SirMstPelanggaranModel
    {
        private string _angId;
        private string _statPelanggaran;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string AngId
        {
            get { return _angId; }
            set { _angId = value; }
        }

        public string StatPelanggaran
        {
            get { return _statPelanggaran; }
            set { _statPelanggaran = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class SirMstPelanggaranDtlModel
    {
        private string _angId;
        private string _transrec;
        private string _nomorPinjam;
        private string _nomorItem;
        private string _jnsDenda;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private int _jnsPelanggaran;


        public string AngId
        {
            get { return _angId; }
            set { _angId = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string NomorPinjam
        {
            get { return _nomorPinjam; }
            set { _nomorPinjam = value; }
        }

        public string NomorItem
        {
            get { return _nomorItem; }
            set { _nomorItem = value; }
        }

        public string JnsDenda
        {
            get { return _jnsDenda; }
            set { _jnsDenda = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public int JnsPelanggaran
        {
            get { return _jnsPelanggaran; }
            set { _jnsPelanggaran = value; }
        }


    }

    public class SirMstPembayaranModel
    {
        private string _codeid;
        private string _descr;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string Codeid
        {
            get { return _codeid; }
            set { _codeid = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class SirMstRulesirkulasiModel
    {
        private string _jumlahPelanggaran;
        private string _ruleName;
        private string _warna;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string JumlahPelanggaran
        {
            get { return _jumlahPelanggaran; }
            set { _jumlahPelanggaran = value; }
        }

        public string RuleName
        {
            get { return _ruleName; }
            set { _ruleName = value; }
        }

        public string Warna
        {
            get { return _warna; }
            set { _warna = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class SirMstTranskembaliModel
    {
        private string _angId;
        private string _nomorKembali;
        private string _statPelanggaran;
        private string _statPinjam;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string AngId
        {
            get { return _angId; }
            set { _angId = value; }
        }

        public string NomorKembali
        {
            get { return _nomorKembali; }
            set { _nomorKembali = value; }
        }

        public string StatPelanggaran
        {
            get { return _statPelanggaran; }
            set { _statPelanggaran = value; }
        }

        public string StatPinjam
        {
            get { return _statPinjam; }
            set { _statPinjam = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class SirMstTranskembaliDtlModel
    {
        private string _angId;
        private string _transrec;
        private string _nomorKembali;
        private string _nomorItem;
        private DateTime _tglKembali;
        private string _jmlHariKeterlambatan;
        private string _statDenda;
        private string _jmlDenda;
        private string _statPinjam;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string AngId
        {
            get { return _angId; }
            set { _angId = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string NomorKembali
        {
            get { return _nomorKembali; }
            set { _nomorKembali = value; }
        }

        public string NomorItem
        {
            get { return _nomorItem; }
            set { _nomorItem = value; }
        }

        public DateTime TglKembali
        {
            get { return _tglKembali; }
            set { _tglKembali = value; }
        }

        public string JmlHariKeterlambatan
        {
            get { return _jmlHariKeterlambatan; }
            set { _jmlHariKeterlambatan = value; }
        }

        public string StatDenda
        {
            get { return _statDenda; }
            set { _statDenda = value; }
        }

        public string JmlDenda
        {
            get { return _jmlDenda; }
            set { _jmlDenda = value; }
        }

        public string StatPinjam
        {
            get { return _statPinjam; }
            set { _statPinjam = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class SirMstTranspinjamModel
    {
        private string _angId;
        private string _nomorPinjam;
        private string _statPelanggaran;
        private string _statPinjam;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string AngId
        {
            get { return _angId; }
            set { _angId = value; }
        }

        public string NomorPinjam
        {
            get { return _nomorPinjam; }
            set { _nomorPinjam = value; }
        }

        public string StatPelanggaran
        {
            get { return _statPelanggaran; }
            set { _statPelanggaran = value; }
        }

        public string StatPinjam
        {
            get { return _statPinjam; }
            set { _statPinjam = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class SirMstTranspinjamDtlModel
    {
        private string _angId;
        private string _transrec;
        private string _nomorPinjam;
        private string _nomorItem;
        private DateTime _tglPinjam;
        private string _tglKembali;
        private string _statPinjam;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string AngId
        {
            get { return _angId; }
            set { _angId = value; }
        }

        public string Transrec
        {
            get { return _transrec; }
            set { _transrec = value; }
        }

        public string NomorPinjam
        {
            get { return _nomorPinjam; }
            set { _nomorPinjam = value; }
        }

        public string NomorItem
        {
            get { return _nomorItem; }
            set { _nomorItem = value; }
        }

        public DateTime TglPinjam
        {
            get { return _tglPinjam; }
            set { _tglPinjam = value; }
        }

        public string TglKembali
        {
            get { return _tglKembali; }
            set { _tglKembali = value; }
        }

        public string StatPinjam
        {
            get { return _statPinjam; }
            set { _statPinjam = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class SirMstTranspinjamOnlineModel
    {
        private string _idAng;
        private string _nomorItem;
        private DateTime _tglPinjam;
        private string _statusPinjam;


        public string IdAng
        {
            get { return _idAng; }
            set { _idAng = value; }
        }

        public string NomorItem
        {
            get { return _nomorItem; }
            set { _nomorItem = value; }
        }

        public DateTime TglPinjam
        {
            get { return _tglPinjam; }
            set { _tglPinjam = value; }
        }

        public string StatusPinjam
        {
            get { return _statusPinjam; }
            set { _statusPinjam = value; }
        }


    }

    public class SirTahunKalendarModel
    {
        private int _tahun;
        private int _keterangan;


        public int Tahun
        {
            get { return _tahun; }
            set { _tahun = value; }
        }

        public int Keterangan
        {
            get { return _keterangan; }
            set { _keterangan = value; }
        }


    }

    public class SirTransCalendarModel
    {
        private int _tahunKerja;
        private int _hariAwal;
        private int _hariAkhir;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public int TahunKerja
        {
            get { return _tahunKerja; }
            set { _tahunKerja = value; }
        }

        public int HariAwal
        {
            get { return _hariAwal; }
            set { _hariAwal = value; }
        }

        public int HariAkhir
        {
            get { return _hariAkhir; }
            set { _hariAkhir = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class SirTransCalendarDtlModel
    {
        private int _id;
        private int _tahunKerja;
        private string _keterangan;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _tglLibur;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int TahunKerja
        {
            get { return _tahunKerja; }
            set { _tahunKerja = value; }
        }

        public string Keterangan
        {
            get { return _keterangan; }
            set { _keterangan = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string TglLibur
        {
            get { return _tglLibur; }
            set { _tglLibur = value; }
        }


    }

    public class TblMstSerialTbDtlModel
    {
        private string _controlnum;
        private string _kardexnumber;
        private string _nomor;
        private string _edisi;
        private string _volume;
        private string _tahun;
        private string _itemClass;
        private string _lokasi;
        private string _tanggalTerbit;
        private string _tanggalTerima;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _harga;


        public string Controlnum
        {
            get { return _controlnum; }
            set { _controlnum = value; }
        }

        public string Kardexnumber
        {
            get { return _kardexnumber; }
            set { _kardexnumber = value; }
        }

        public string Nomor
        {
            get { return _nomor; }
            set { _nomor = value; }
        }

        public string Edisi
        {
            get { return _edisi; }
            set { _edisi = value; }
        }

        public string Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }

        public string Tahun
        {
            get { return _tahun; }
            set { _tahun = value; }
        }

        public string ItemClass
        {
            get { return _itemClass; }
            set { _itemClass = value; }
        }

        public string Lokasi
        {
            get { return _lokasi; }
            set { _lokasi = value; }
        }

        public string TanggalTerbit
        {
            get { return _tanggalTerbit; }
            set { _tanggalTerbit = value; }
        }

        public string TanggalTerima
        {
            get { return _tanggalTerima; }
            set { _tanggalTerima = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string Harga
        {
            get { return _harga; }
            set { _harga = value; }
        }


    }

    public class TblMstSerialTbDtlKardexModel
    {
        private string _kardexId;
        private string _kardexNumber;
        private string _nomorItem;
        private string _lokasi;
        private string _keterangan;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string KardexId
        {
            get { return _kardexId; }
            set { _kardexId = value; }
        }

        public string KardexNumber
        {
            get { return _kardexNumber; }
            set { _kardexNumber = value; }
        }

        public string NomorItem
        {
            get { return _nomorItem; }
            set { _nomorItem = value; }
        }

        public string Lokasi
        {
            get { return _lokasi; }
            set { _lokasi = value; }
        }

        public string Keterangan
        {
            get { return _keterangan; }
            set { _keterangan = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class UmGroupModel
    {
        private string _groupCode;
        private string _groupName;
        private string _modCode;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string GroupCode
        {
            get { return _groupCode; }
            set { _groupCode = value; }
        }

        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }

        public string ModCode
        {
            get { return _modCode; }
            set { _modCode = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class UmGroupAccessModel
    {
        private int _id;
        private string _groupCode;
        private string _mnCode;
        private string _accView;
        private string _accInsert;
        private string _accEdit;
        private string _accDelete;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string GroupCode
        {
            get { return _groupCode; }
            set { _groupCode = value; }
        }

        public string MnCode
        {
            get { return _mnCode; }
            set { _mnCode = value; }
        }

        public string AccView
        {
            get { return _accView; }
            set { _accView = value; }
        }

        public string AccInsert
        {
            get { return _accInsert; }
            set { _accInsert = value; }
        }

        public string AccEdit
        {
            get { return _accEdit; }
            set { _accEdit = value; }
        }

        public string AccDelete
        {
            get { return _accDelete; }
            set { _accDelete = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class UmLevelModel
    {
        private string _levelCode;
        private string _levelName;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string LevelCode
        {
            get { return _levelCode; }
            set { _levelCode = value; }
        }

        public string LevelName
        {
            get { return _levelName; }
            set { _levelName = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class UmLevelAccessModel
    {
        private int _id;
        private string _levelCode;
        private string _groupCode;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string LevelCode
        {
            get { return _levelCode; }
            set { _levelCode = value; }
        }

        public string GroupCode
        {
            get { return _groupCode; }
            set { _groupCode = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class UmMenuModel
    {
        private string _mnCode;
        private string _mnName;
        private string _mnPath;
        private string _modCode;
        private string _mnParent;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string MnCode
        {
            get { return _mnCode; }
            set { _mnCode = value; }
        }

        public string MnName
        {
            get { return _mnName; }
            set { _mnName = value; }
        }

        public string MnPath
        {
            get { return _mnPath; }
            set { _mnPath = value; }
        }

        public string ModCode
        {
            get { return _modCode; }
            set { _modCode = value; }
        }

        public string MnParent
        {
            get { return _mnParent; }
            set { _mnParent = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class UmModulModel
    {
        private string _modCode;
        private string _modName;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;


        public string ModCode
        {
            get { return _modCode; }
            set { _modCode = value; }
        }

        public string ModName
        {
            get { return _modName; }
            set { _modName = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }


    }

    public class UmUserModel
    {
        private string _nip;
        private string _nama;
        private string _inisial;
        private string _password;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _lastLoginDate;
        private string _activated;
        private string _otorisasi;


        public string Nip
        {
            get { return _nip; }
            set { _nip = value; }
        }

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string Inisial
        {
            get { return _inisial; }
            set { _inisial = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string LastLoginDate
        {
            get { return _lastLoginDate; }
            set { _lastLoginDate = value; }
        }

        public string Activated
        {
            get { return _activated; }
            set { _activated = value; }
        }

        public string Otorisasi
        {
            get { return _otorisasi; }
            set { _otorisasi = value; }
        }


    }

    public class UmUserAccessModel
    {
        private int _id;
        private string _nip;
        private string _createdBy;
        private string _createdDate;
        private string _lastUpdBy;
        private string _lastUpdDate;
        private string _groupCode;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nip
        {
            get { return _nip; }
            set { _nip = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string LastUpdBy
        {
            get { return _lastUpdBy; }
            set { _lastUpdBy = value; }
        }

        public string LastUpdDate
        {
            get { return _lastUpdDate; }
            set { _lastUpdDate = value; }
        }

        public string GroupCode
        {
            get { return _groupCode; }
            set { _groupCode = value; }
        }


    }



}
