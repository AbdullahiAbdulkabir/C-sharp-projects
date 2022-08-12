using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable phoneBook = new Hashtable()
            {
             {"Damiola","08127003007"},
             {"Abdullahi","08127003007"},
             {"musa","08127003007"},
             {"Damiola","08127003007"}
            };
            phoneBook["Musa Animashaun"] = "08173911637";
            phoneBook["Khadijah"] = "08081911637";

            try
            {
                phoneBook.Add("TQ", "01208341014");
                phoneBook.Add("HIKMAH", "01208341014");
                phoneBook.Add("ABUBAKR", "08012081014");
                phoneBook.Add("RUUOIU", "081208341014");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entry already exist");
            }

            if (phoneBook.Count ==0)
            {
                Console.WriteLine("EMPTY");                
            }


        }
    }
}
