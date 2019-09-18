using System;
using System.Collections.Generic;

namespace AuthAPI.Models
{
    public partial class Asset
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public int? BuildingId { get; set; }
        public byte[] AssetImage { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }

        public Buldings Building { get; set; }
    }
}
