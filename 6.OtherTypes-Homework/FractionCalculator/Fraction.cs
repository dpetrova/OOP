using System;

namespace FractionCalculator
{
    using System.Globalization;

    public struct Fraction
    {
        //private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator): this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator { get; set; }
        

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be 0");
                }
                this.denominator = value;
            }
        }


        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            long numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            long denominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator - (Fraction f1, Fraction f2)
        {
            long numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
            long denominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denominator);
        }
        
        public override string ToString()
        {
            return ((double)this.Numerator / this.Denominator).ToString(CultureInfo.InvariantCulture);
        }
    }
}
