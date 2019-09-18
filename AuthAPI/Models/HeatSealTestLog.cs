using System;
using System.Collections.Generic;

namespace AuthAPI.Models
{
    public partial class HeatSealTestLog
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? CorrectiveActionTest { get; set; }
        public int? TestedtedAtTest { get; set; }
        public string SuperWisorInitials { get; set; }
        public string Comments { get; set; }
    }
}
