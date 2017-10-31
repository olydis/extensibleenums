namespace EnumTests
{
    public struct TaxAmountEnums: System.IEquatable<TaxAmountEnums>
    {
        private TaxAmountEnums(double value)
        {
            Value = value;
        }

        public static implicit operator TaxAmountEnums(double value) => new TaxAmountEnums(value);

        public static bool operator ==(TaxAmountEnums m1, TaxAmountEnums m2) => m2.Equals(m1);

        public static bool operator !=(TaxAmountEnums m1, TaxAmountEnums m2) => !m2.Equals(m1);

        public override bool Equals(object obj) => obj is TaxAmountEnums e && this.Equals(e);

        public bool Equals(TaxAmountEnums m) => GetBaseValueForAllowedValue(Value).Equals(GetBaseValueForAllowedValue(m.Value));

        public override int GetHashCode() => GetBaseValueForAllowedValue(Value).GetHashCode();

        public double Value { get; private set; }

        private static double GetBaseValueForAllowedValue(double value)
        {
            switch(value)
            {
                case 1.1:
                case 1.2:
                case 1.3:
                     return 1.0;
                case 2.1:
                case 2.2:
                     return 2.0;
                case 3.1:
                     return 3.0;
                default: return value;
            }
        }


    }

}
