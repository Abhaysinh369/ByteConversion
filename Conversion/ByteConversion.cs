using System;
using System.Collections.Generic;
using System.Text;

namespace Conversion
{
    public static class ByteConversion
    {

        public static int ConvertMegabytestoBytes(int inputu)
        {
            int ans = inputu * 1048576;
            Console.WriteLine("Number bytes is"+ " " + ans + "\n");
            return ans;
        }
        public static double ConvertGigabytestoMegaBytes(int inputu)
        {
            int ans = inputu * 1024;
            Console.WriteLine("Number Megabytes is" + " " + ans +"\n");
            return ans;
        }
        public static double ConvertTerabytestoGigaBytes(int inputu)
        {
            int ans = inputu * 1024;
            Console.WriteLine("Number Gigabytes is" + " " + ans + "\n");
            return ans;
        }
    }
}
