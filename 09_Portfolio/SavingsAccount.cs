using System;

namespace _09_Portfolio
{

    internal class SavingsAccount : IAsset
    {
    
        private string account;
        private double interestrate;
        private double value1;

        public string Account { get { return account; } set { account = value; } }
        public double InterestRate { get { return interestrate; } set { interestrate = value; } }
        public double Value { get { return value1; } set { value1 = value; } }
        public override string ToString()
        {
            //string format = "SavingsAccount[value=" + Value + ",interestRate=" + InterestRate + "]";
            string format = string.Format("SavingsAccount[value={0:0.0},interestRate={1:0.0}]", Value, InterestRate);
            return format;
        }
        public SavingsAccount(string v1, double v2, double v3)
        {
            Account = v1;
            Value =  v2;
            InterestRate = v3;
        }

        internal double GetValue()
        {
            return Value;
        }

        internal void ApplyInterest()
        {
            Value += InterestRate / 100 * Value;
        }
    }
}