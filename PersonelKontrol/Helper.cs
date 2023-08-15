using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PersonelKontrol
{
    public static class Helper
    {
        private static Random rnd = new Random(); 
        public static int SayiÜret(int min=1, int max = 200)
        {
            return rnd.Next(min,max+1);
        }

    }

}
