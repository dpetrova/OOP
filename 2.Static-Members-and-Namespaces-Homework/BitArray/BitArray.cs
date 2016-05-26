using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//to enable C# 6.0 feature in Visual Studio 2013, install the new compilers into the project as a nuget package:
//PM> Install-Package Microsoft.Net.Compilers -Version 1.0.0

namespace BitArray
{
    public class BitArray
    {
        private int[] num;

        public BitArray(int numberOfBits)
        {
            this.num = new int[numberOfBits];
        }

        public int this[int pos]
        {
            get { return this.GetBitAtPos(pos); }
            set { this.SetBitAtPos(pos, value); }
        }


        public int GetBitAtPos(int pos)
        {
            if (pos < 0 || pos > this.num.Length - 1)
            {
                throw new ArgumentOutOfRangeException($"Position should be in range [0...{this.num.Length}]");
            }
            return this.num[pos];
        }

        public void SetBitAtPos(int pos, int bit)
        {
            if (pos < 0 || pos > this.num.Length - 1)
            {
                throw new ArgumentOutOfRangeException($"Position should be in range [0...{this.num.Length}]");
            }

            if (bit != 0 && bit != 1)
            {
                throw new ArgumentException("Bit should be either 0 or 1");
            }

            this.num[pos] = bit;
        }

        
        public override string ToString()
        {
            long number = 0;
            for (int i = 0; i < this.num.Length; i++)
            {
                number = number + int.Parse("" + this.num[i]) * (long)Math.Pow(2, i);
            }
        
            return number.ToString();
        }

    }
}
