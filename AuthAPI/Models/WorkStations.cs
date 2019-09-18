using System;
using System.Collections.Generic;

namespace AuthAPI.Models
{
    public partial class WorkStations
    {
        public WorkStations()
        {
            Buldings = new HashSet<Buldings>();
        }

        public int Wsid { get; set; }
        public string StationType { get; set; }
        public DateTime? CreatedDate { get; set; }

        public ICollection<Buldings> Buldings { get; set; }
    }
}
