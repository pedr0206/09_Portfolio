using System;

namespace _09_Portfolio
{
    internal class Stock : IAsset
    {
        private int numShares;
        private double pricePerShare;
        private string symbol;
        public Stock()
        {
        }
        public Stock( string a, double b, double c)
        {
            
        }

        public int NumShares { get { return numShares; } internal set { numShares = value; } }
        public double PricePerShare { get { return pricePerShare; } internal set { pricePerShare = value; } }
        public string Symbol { get { return symbol; } internal set { symbol = value; } }

        internal int GetValue()
        {
            throw new NotImplementedException();
        }

        internal static double TotalValue(Stock[] stocks)
        {
            throw new NotImplementedException();
        }
    }
}