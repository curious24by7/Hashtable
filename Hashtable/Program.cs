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
<<<<<<< HEAD
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are"); 
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situations");
            //hash.Remove("17");
            string hashAvoidable=hash.Get("17");
            Console.WriteLine(hashAvoidable);
=======
            const string PARAGRAPH = "to be or not to be";
            Console.WriteLine("Input Paragraph is:: '"+PARAGRAPH+"'");
            hash.FindFrequency(PARAGRAPH, "be");
>>>>>>> UC1
            Console.ReadKey();
        }
    }
}
