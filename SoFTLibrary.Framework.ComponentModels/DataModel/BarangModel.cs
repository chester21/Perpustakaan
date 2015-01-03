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
}
