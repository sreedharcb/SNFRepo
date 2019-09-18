using System;
using System.Collections.Generic;

namespace AuthAPI.Models
{
    public partial class LidPouch
    {
        public int Id { get; set; }
        public int LidPouchNumber { get; set; }
        public int? SealerTemp { get; set; }
        public int? SealerPressure { get; set; }
        public int? SealerTime { get; set; }
        public bool? LidOrPouch { get; set; }
    }
}
