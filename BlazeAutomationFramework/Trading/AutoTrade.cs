using BlazeAutomationFramework.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazeAutomationFramework.Trading
{
    class AutoTrade
    {
        List<StockData> stockHistory = new List<StockData> { };
        private StockData currentStockData;

        public bool bBuy { get; private set; }
        public bool bSell { get; private set; }
        public bool isPriceGrowing { get; private set; }
        public bool isPriceLowering { get; private set; }
        public NativeINIReadWrite SettingsReadWrite { get; internal set; }
        public string CurrentStockSettings { get; internal set; }
        public StockData lastStockData { get; private set; }

        internal void UpdateData(string CurrentStockPrice, string ByingPrice, string StockSellingPrice, string StockValueChange, string StockOwned)
        {
            if (StockSellingPrice == "") { StockSellingPrice = "0"; }
            if (StockOwned == "") { StockOwned = "0"; }
            if(stockHistory.Count > 20) { stockHistory.Clear(); }
            StockData stock = new StockData();
            stock.CurrentStockPrice = double.Parse(CurrentStockPrice);
            stock.ByingPrice = double.Parse(ByingPrice);
            stock.StockSellingPrice = double.Parse(StockSellingPrice);
            stock.StockValueChange = double.Parse(StockValueChange);
            stock.StockOwned = double.Parse(StockOwned);
            stock.EntryDate = DateTime.Now;
            if (stockHistory.Count > 0)
            {
                lastStockData = stockHistory.Last();
            }
            stockHistory.Add(stock);
            bBuy = false;
            bSell = false;
            string section = stock.EntryDate.Year + "-" + stock.EntryDate.Month + "-" + stock.EntryDate.Day + " " + stock.EntryDate.Hour + ":" + stock.EntryDate.Minute;
            SettingsReadWrite.INIWrite(CurrentStockSettings, section, "CurrentStockPrice", CurrentStockPrice);
            SettingsReadWrite.INIWrite(CurrentStockSettings, section, "ByingPrice", ByingPrice);
            SettingsReadWrite.INIWrite(CurrentStockSettings, section, "StockSellingPrice", StockSellingPrice);
            SettingsReadWrite.INIWrite(CurrentStockSettings, section, "StockValueChange", StockValueChange);
            SettingsReadWrite.INIWrite(CurrentStockSettings, section, "StockOwned", StockOwned);
            currentStockData = stock;
        }

        internal bool Buy()
        {
            return bBuy;
        }

        internal bool Sell()
        {
            return bSell;
        }

        internal void Analyze()
        {
            bBuy = false;
            bSell = false;
            if (currentStockData.StockOwned == 0)
            {
                if (lastStockData != null)
                {
                    if (currentStockData.CurrentStockPrice >= lastStockData.CurrentStockPrice)
                    {
                        bBuy = BuyStock();
                    }
                }
                    
            }
            if (currentStockData.StockOwned > 0)
            {
                if(lastStockData != null)
                {
                    if(currentStockData.CurrentStockPrice <= lastStockData.CurrentStockPrice)
                    {
                        bSell = SellStock();
                    }
                }
            }
           
            
        }

        private bool SellStock()
        {
            bool result = false;
            if (stockHistory.Count > 10)
            {
                double averagePrice = 0;
                double totalPrice = 0;
                foreach (StockData stock in stockHistory)
                {
                    totalPrice += stock.CurrentStockPrice;
                }
                averagePrice = totalPrice / stockHistory.Count;
                double diff = averagePrice - currentStockData.CurrentStockPrice;
                Console.WriteLine("SellStock diff: " + diff);
                if (diff <= 0)
                {
                    Console.WriteLine("Setting position to zero.");
                    result = true;
                }
            }
            return result;
        }

        private bool BuyStock()
        {
            bool result = false;
            if (stockHistory.Count > 10)
            {
                double averagePrice = 0;
                double totalPrice = 0;
                foreach (StockData stock in stockHistory)
                {
                    totalPrice += stock.CurrentStockPrice;
                }
                averagePrice = totalPrice / stockHistory.Count;
                double diff = averagePrice - currentStockData.CurrentStockPrice;
                Console.WriteLine("BuyStock diff: " + diff);
                if (diff >= 0)
                {
                    Console.WriteLine("Buy stock!");
                    result = true;
                }
            }
            return result;
        }
    }
}
