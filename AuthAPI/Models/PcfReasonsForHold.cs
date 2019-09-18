using System;
using System.Collections.Generic;

namespace AuthAPI.Models
{
    public partial class PcfReasonsForHold
    {
        public PcfReasonsForHold()
        {
            PcfSubReasonsForHold = new HashSet<PcfSubReasonsForHold>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PcfSubReasonsForHold> PcfSubReasonsForHold { get; set; }
    }
}
