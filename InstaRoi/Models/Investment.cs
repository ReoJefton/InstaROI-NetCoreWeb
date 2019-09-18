using System;
using System.Collections.Generic;

namespace InstaRoi.Models
{
    public partial class Investment
    {
        public int Id { get; set; }
        public string InvestmentType { get; set; }
        public int Field { get; set; }
    }
}
