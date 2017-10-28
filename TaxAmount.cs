namespace EnumTests
{
    public struct TaxAmountEnums: System.IEquatable<TaxAmountEnums>
    {
        private TaxAmountEnums(double value)
        {
            Value = value;
        }

        public static implicit operator TaxAmountEnums(double value) 
        { 
            var baseType = GetBaseTypeForAllowedType(value);
            return (baseType == null)? new TaxAmountEnums(value): (TaxAmountEnums)baseType;
        }

        private static TaxAmountEnums GetBaseTypeForAllowedType(TaxAmountEnums other)
        {
            return new TaxAmountEnums();
        }        

        public static bool operator ==(TaxAmountEnums m1, TaxAmountEnums m2) => m2.Equals(m1);

        public static bool operator !=(TaxAmountEnums m1, TaxAmountEnums m2) => !m2.Equals(m1);

        public override bool Equals(object obj) => this.Equals(((TaxAmountEnums)obj));

        public bool Equals(TaxAmountEnums m) => ( GetBaseTypeForAllowedType(m.Value)!=null || Value.Equals(m.Value));

        public override int GetHashCode()
        {
            var baseType = GetBaseTypeForAllowedType(this);
            if(baseType!=null)
            {
                return baseType.Value.GetHashCode();
            }
            return Value.GetHashCode();
        }

        public double Value {get; private set;}

        private static TaxAmountEnums? GetBaseTypeForAllowedType(double value)
        {
            switch(value)
            {
                case 1.1: return new TaxAmountEnums(1.0);
                case 1.2: return new TaxAmountEnums(1.0);
                case 1.3: return new TaxAmountEnums(1.3);
                case 2.1: return new TaxAmountEnums(2.0);
                case 2.2: return new TaxAmountEnums(2.0);
                case 3.1: return new TaxAmountEnums(3.0);
                default: return null;
            }
        }


    }

}