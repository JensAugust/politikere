using readcsv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] read;
            char[] seperators = { ',' };
            List<politiker> folketing = new List<politiker>();
            StreamReader sr = new StreamReader($"C:/Users/jensa/OneDrive/Dokumenter/folketing/Folketing.csv");
            {
                string navn1 = "";
                string parti1 = "";
                string email1 = "";
                string mobil1 = "";

                string data = sr.ReadLine();

                while ((data = sr.ReadLine()) != null)
                {
                    // read = data.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                    read = data.Split(seperators);

                    if (read.Count() > 3)
                    {
                        navn1 = read[0];
                        parti1 = read[1];
                        email1 = read[2];
                        mobil1 = read[3];
                    }
                    else
                    {
                        navn1 = read[0];
                        parti1 = read[1];
                        email1 = read[2];
                        mobil1 = "";
                    }
                    
                    // getantalinstancer er en static metode og derfor 
                    folketing.Add(new politiker() { navn = navn1, parti = parti1, email = email1, mobil = mobil1 });
                    Console.WriteLine("Antal politikere: " + politiker.getinstancer());

                    Console.WriteLine("Data fra CSV {0} {1} {2} {3}", navn1, parti1, email1, mobil1);
                }
            }
            int stemnej = 0;
            int stemja =0;
            foreach (politiker item in folketing)
            {
                if (politiker.Afstemning() == false)
                {
                    stemnej++;
                }
                else
                {
                    stemja++;
                }
                //Console.WriteLine("Afstemning: " + politiker.Afstemning());
            }
            if (stemja > stemnej)
            {
                Console.WriteLine("\nLovforslaget er hermed blevet vedtaget!");
            }
            if (stemnej > stemja)
            {
                Console.WriteLine("\nLovforslaget blev desværre forkastet");
            }
            if (stemnej==stemja)
            {
                Console.WriteLine("\nDet står lige! Der bliver nød til at ske en ny afstemning");
            }
            Console.ReadKey();
        }
    }
}
