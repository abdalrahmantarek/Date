using System.Globalization;
using System.Net;
using System.Threading.Channels;
using System.Xml.Schema;

namespace _004
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Date d1 = new Date(2001,2,32);
            Console.WriteLine(d1.getDate());
            /// ones counter
            //{
            //    var counter = 0;
            //    for (int i = 0; i < 1000000; i++)
            //    {
            //        string str = i.ToString();
            //        counter += str.Count(c => c == '1');
            //    }
            //}



        }
       
    }

}   
