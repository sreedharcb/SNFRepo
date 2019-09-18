using System;
using System.Collections.Generic;

namespace AuthAPI.Models
{
    public partial class ProductWorkOrder
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int? MaterialNumber { get; set; }
        public int? BatchNumber { get; set; }
    }
}
