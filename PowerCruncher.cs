using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerCruncher
{

    public class PowerCruncher
    {
        public PowerCruncher()
        {   // 0=column multiplier, 1=digit, 2=radix, 3=power
            formatString = "{2}^{3}x{1}";
            joinString = " + ";
        }
        public string formatString { get; set; }
        public string joinString { get; set; }

        public string getPowers(int input)
        {
            return getPowers(input, 2);
        }

        public string getPowers(int input, int radix)
        {
            var remainder = input;
            int power = 0;
            var results = new List<string>();
            while (true) {
                int digit = remainder % radix;
                results.Add(string.Format(formatString, (int)Math.Pow(radix, power), digit, radix, power));                   
                remainder -= digit;
                remainder /= radix;
                power++;

                if (remainder <= 0) { break; }

            }
            return string.Join(this.joinString, results.Reverse<string>());
        }
    }
}
