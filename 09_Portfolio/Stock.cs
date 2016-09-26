using System;

namespace _09_Portfolio
{
    internal class Stock : IAsset
    {
        private double numShares;
        private double pricePerShare;
        private string symbol;
        public Stock()
        {
        }
        public Stock( string a, double b, double c)
        {
            Symbol = a;
            PricePerShare = b;
            NumShares = c;
        }

        public double NumShares { get { return numShares; } internal set { numShares = value; } }
        public double PricePerShare { get { return pricePerShare; } internal set { pricePerShare = value; } }
        public string Symbol { get { return symbol; } internal set { symbol = value; } }

        internal double GetValue()
        {
            return PricePerShare* NumShares;
        }

        internal static double TotalValue(Stock[] stocks)
        {
            double x = stocks[0].GetValue();
            double y = stocks[1].GetValue();
            return x + y;
        }
        public override string ToString()
        {
            string format = "Stock[symbol=" + Symbol + ",pricePerShare=" + PricePerShare + ",numShares=" + NumShares + "]";
            return format;
        }

        public override bool Equals(object obj)
        {
            Stock Compareobject = (Stock)obj;
            if (Compareobject.Symbol == this.Symbol && Compareobject.PricePerShare == this.PricePerShare && Compareobject.NumShares == this.NumShares)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static object TotalValue(IAsset[] portfolio)
        {
            throw new NotImplementedException();
        }
    }
}