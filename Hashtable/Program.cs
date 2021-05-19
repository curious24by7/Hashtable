using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash table demo"); 
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            const string PARAGRAPH = "to be or not to be";
            Console.WriteLine("Input Paragraph is:: '"+PARAGRAPH+"'");
            hash.FindFrequency(PARAGRAPH, "be");
            Console.ReadKey();
        }
    }
}
