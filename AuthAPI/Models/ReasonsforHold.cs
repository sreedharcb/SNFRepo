using System;
using System.Collections.Generic;

namespace AuthAPI.Models
{
    public partial class ReasonsforHold
    {
        public int Id { get; set; }
        public int ReasonId { get; set; }
        public string Reason { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
