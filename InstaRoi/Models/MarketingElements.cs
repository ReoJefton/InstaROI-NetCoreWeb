using System;
using System.Collections.Generic;

namespace InstaRoi.Models
{
    public partial class MarketingElements
    {
        public int ElementId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string ElementName { get; set; }
        public string ElementType { get; set; }
        public string ElementDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string InvestmentField { get; set; }
        public int? Investment1 { get; set; }
        public int? Investment2 { get; set; }
        public int? Investment3 { get; set; }
        public int? Investment4 { get; set; }
        public int? Investment5 { get; set; }
        public int? Investment6 { get; set; }
        public int NumberOfLeads { get; set; }
        public decimal ConversionPercentage { get; set; }
        public int ConversionValue { get; set; }
        public decimal? Profit { get; set; }
        public decimal? Roi { get; set; }
        public decimal? RoiPercentage { get; set; }

        //public int ElementId { get; set; }
        //public int? UserId { get; set; }
        //public string UserName { get; set; }
        //public string ElementName { get; set; }
        //public string ElementType { get; set; }
        //public string ElementDescription { get; set; }
        //public DateTime? StartDate { get; set; }
        //public DateTime? EndDate { get; set; }
        //public string InvestmentField { get; set; }
        //public decimal? Investment1 { get; set; }
        //public decimal? Investment2 { get; set; }
        //public decimal? Investment3 { get; set; }
        //public decimal? Investment4 { get; set; }
        //public decimal? Investment5 { get; set; }
        //public decimal? Investment6 { get; set; }
        //public decimal? NumberOfLeads { get; set; }
        //public decimal ConversionPercentage { get; set; }
        //public decimal? ConversionValue { get; set; }
        //public decimal? Profit { get; set; }
        //public decimal? Roi { get; set; }
        //public decimal? RoiPercentage { get; set; }
    }
}
