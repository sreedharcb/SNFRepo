using System;
using System.Collections.Generic;

namespace AuthAPI.Models
{
    public partial class Buldings
    {
        public Buldings()
        {
            Asset = new HashSet<Asset>();
        }

        public int Id { get; set; }
        public int? Wsid { get; set; }
        public string BuildingName { get; set; }
        public DateTime? CreatedDate { get; set; }

        public WorkStations Ws { get; set; }
        public ICollection<Asset> Asset { get; set; }
    }
}
