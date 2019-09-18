using System;
using System.Collections.Generic;

namespace AuthAPI.Models
{
    public partial class PcfSubReasonsForHold
    {
        public int Id { get; set; }
        public int? ReasonId { get; set; }
        public string Name { get; set; }

        public PcfReasonsForHold Reason { get; set; }
    }
}
