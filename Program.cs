using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_ogreniyorum
{    class HesapMakinesi
    { public int Topla(int a, int b)
        {
            return a + b;
        
        }
    public int Cikar(int a, int b)
    { return a-b;
        
    }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HesapMakinesi hm = new HesapMakinesi();
            int sonuc = hm.Topla(12, 27);
            Console.WriteLine(sonuc);
            int negsonuc= hm.Cikar;
            Console.Writeline(negsonuc);
        }
    }
}
