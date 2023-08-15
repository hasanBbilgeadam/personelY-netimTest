using System.Diagnostics;
using System.Runtime.InteropServices;

namespace uygulama_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

             

        }
    }

    public static class RNSayi
    {
        private static Random rn = new Random();
        public static int sayiÜRet()
        {
            return rn.Next(1, 222);
        } 
    }
}