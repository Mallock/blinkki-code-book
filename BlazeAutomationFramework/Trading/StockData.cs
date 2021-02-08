using System;

namespace BlazeAutomationFramework.Trading
{
    internal class StockData
    {
        public double CurrentStockPrice { get; internal set; }
        public double ByingPrice { get; internal set; }
        public double StockSellingPrice { get; internal set; }
        public double StockValueChange { get; internal set; }
        public double StockOwned { get; internal set; }
        public DateTime EntryDate { get; internal set; }
    }
}