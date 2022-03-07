using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HSetDemo
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Arka Mitra");
            ht.Add("2", "Yashwanth");
            ht.Add("3", "Pinki");
            ht.Add("4", "Rajesh");
            ht.Add("5", "Pramod");

            Console.WriteLine("Hash Table Data are  ");
            foreach(DictionaryEntry ent in ht)
            {
                Console.WriteLine(ent.Key + "   " +ent.Value);
            }
        }
    }
}
